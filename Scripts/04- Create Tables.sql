--USER ROLES
CREATE TABLE IF NOT EXISTS user_roles(
	user_role serial PRIMARY KEY,
	role_description VARCHAR(100),
	end_date TIMESTAMP
);

--USERS
CREATE TABLE IF NOT EXISTS users(
	user_id VARCHAR(20) PRIMARY KEY,
	username VARCHAR(200) NOT NULL,
	password TEXT NOT NULL,
	user_role INTEGER REFERENCES user_roles(user_role) NOT NULL,
	modified_at TIMESTAMP,
	modified_by VARCHAR(20) REFERENCES users(user_id),
	end_date TIMESTAMP,
	endated_by VARCHAR(20) REFERENCES users(user_id)
);

--INSERT USER ROLES
INSERT INTO user_roles (role_description) VALUES ('Administrador'), ('Mantenimiento'), ('Consulta');

--CREATE THE INITIAL USER, USING ENCRYPTOR
INSERT INTO users (user_id, username, password, user_role, created_at) VALUES ('admin', 'Admin', 'YourEncryptedPassword', 1, now());

--ASSET TYPES
CREATE TABLE IF NOT EXISTS asset_types(
	asset_type_id serial PRIMARY KEY,
	type_description VARCHAR(200) NOT NULL,
	created_at TIMESTAMP NOT NULL DEFAULT now(),
	created_by VARCHAR(20) REFERENCES users(user_id) NOT NULL,
	modified_at TIMESTAMP,
	modified_by VARCHAR(20) REFERENCES users(user_id),
	end_date TIMESTAMP,
	endated_by VARCHAR(20) REFERENCES users(user_id)
);

CREATE OR REPLACE FUNCTION check_related_records(related_table VARCHAR, column_name VARCHAR, related_table_es VARCHAR)
RETURNS TRIGGER AS $$
BEGIN
	IF NEW.end_date IS NOT NULL THEN
		EXECUTE FORMAT('
			IF EXISTS (SELECT 1 FROM assets WHERE %I = OLD.%I) THEN
				RAISE EXCEPTION ''No se puede finalizar el %s. Existen activos relacionados con este registro.'';
			END IF;
			', related_table, column_name, column_name, related_table_es);
	END IF;
	RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER check_assets_before_end_date
BEFORE UPDATE 
ON sch_asset_control.asset_types
FOR EACH ROW
EXECUTE FUNCTION sch_asset_control.check_related_records('asset_type','el Tipo de Activo');

--ASSET STATUS
CREATE TABLE IF NOT EXISTS asset_status(
	status serial PRIMARY KEY,
	status_description VARCHAR(100)
);

--INSERT STATUSES
INSERT INTO asset_status (status_description) VALUES ('Buen estado'), ('En garantía'), ('En reparación'), ('Reparable');

--ASSET RETIREMENT REASONS
CREATE TABLE IF NOT EXISTS asset_retirement_reasons(
	retirement_reason serial PRIMARY KEY,
	reason_description VARCHAR(100)
);

--INSERT RETIREMENT REASONS
INSERT INTO asset_retirement_reasons (reason_description) VALUES ('Daño irreparable'), ('Deterioro'), ('Robo'), ('Extravío'), ('Error administrativo'), ('Venta'), ('Trasladado');

--BRANCHES
CREATE TABLE IF NOT EXISTS branches(
	branch_id serial PRIMARY KEY,
	branch_description VARCHAR(200),
	created_at TIMESTAMP,
	created_by VARCHAR(20),
	modified_at TIMESTAMP,
	modified_by VARCHAR(20),
	end_date TIMESTAMP,
	endated_by VARCHAR(20) REFERENCES users(user_id)
);

CREATE OR REPLACE TRIGGER check_assets_before_end_date
BEFORE UPDATE 
ON sch_asset_control.branches
FOR EACH ROW
EXECUTE FUNCTION sch_asset_control.check_related_records('branch','la Filial');

--ASSET LOCATIONS
CREATE TABLE IF NOT EXISTS asset_locations(
	asset_location_id serial PRIMARY KEY,
	location_description VARCHAR(100),
	created_at TIMESTAMP,
	created_by VARCHAR REFERENCES users(user_id),
	modified_at TIMESTAMP,
	modified_by VARCHAR(20) REFERENCES users(user_id),
	end_date TIMESTAMP,
	endated_by VARCHAR(20) REFERENCES users(user_id)
);

CREATE OR REPLACE TRIGGER check_assets_before_end_date
BEFORE UPDATE 
ON sch_asset_control.asset_locations
FOR EACH ROW
EXECUTE FUNCTION sch_asset_control.check_related_records('asset_locations','la Ubicación');

--ASSETS
CREATE TABLE IF NOT EXISTS assets(
	asset_id serial PRIMARY KEY,
	asset_description VARCHAR(200) NOT NULL,
	asset_type INTEGER REFERENCES asset_types(asset_type) NOT NULL,
	status INTEGER REFERENCES asset_status(status) NOT NULL,
	asset_location INTEGER REFERENCES asset_locations(asset_location_id),
	price double precision,
	branch INTEGER REFERENCES branches(branch_id) NOT NULL,
	observations TEXT,
	asset_tag VARCHAR(100),
	serial_number varchar(100),
	generic_asset BOOLEAN NOT NULL DEFAULT false,
	quantity INTEGER NOT NULL DEFAULT 1,
	purchase_date TIMESTAMP,	
	warranty_months INTEGER,
	created_at TIMESTAMP,
	created_by VARCHAR(20) REFERENCES users(user_id) NOT NULL,
	modified_at TIMESTAMP,
	modified_by VARCHAR(20) REFERENCES users(user_id),
	retirement_reason INTEGER REFERENCES asset_retirement_reasons(retirement_reason),
	end_date TIMESTAMP,
	endated_by VARCHAR(20) REFERENCES users(user_id),
	endate_note TEXT
);

CREATE OR REPLACE FUNCTION check_unique_values()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW.serial_number IS NOT NULL THEN
        IF EXISTS (SELECT 1 
                   FROM assets 
                   WHERE serial_number = NEW.serial_number 
                   AND asset_id <> NEW.asset_id) 
        THEN
            RAISE EXCEPTION 'Ya existe un activo con el mismo número de serie.';
        END IF;
    END IF;

	IF NEW.asset_tag IS NOT NULL THEN
		IF EXISTS (SELECT 1
				   FROM assets
				   WHERE asset_tag = NEW.asset_tag
				   AND asset_id <> NEW.asset_id)
		THEN
			RAISE EXCEPTION 'Ya existe un activo con el mismo número de placa.';
		END IF;
	END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER check_unique_values_before_insert_or_update
BEFORE INSERT OR UPDATE ON assets
FOR EACH ROW
EXECUTE PROCEDURE check_unique_values();


--LOGS TABLE
CREATE TABLE IF NOT EXISTS audit_logs(
	log_id serial PRIMARY KEY,
	log_date TIMESTAMP NOT NULL DEFAULT now(),
	user_id VARCHAR(20) REFERENCES users(user_id) NOT NULL,
	action VARCHAR(100),
	table_name VARCHAR(100),
	record_id VARCHAR(20),
	old_value TEXT,
	new_value TEXT,
	details TEXT
);