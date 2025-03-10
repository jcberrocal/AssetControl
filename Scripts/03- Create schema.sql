CREATE SCHEMA sch_asset_control
    AUTHORIZATION usr_asset_control;
	
ALTER ROLE usr_asset_control
    SET search_path TO sch_asset_control;