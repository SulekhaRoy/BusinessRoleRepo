select * from GPSLocationHeader

select * from GPSLocationDetail order by GPSLocationID

select * from FillComboData where type = 'LOC'

--INSERT INTO FillComboData VALUES(48,0,1,'Office','OF','LOC','Check-In/Check-Out location',0)
--INSERT INTO FillComboData VALUES(49,0,2,'Home','HM','LOC','Check-In/Check-Out location',0)
--INSERT INTO FillComboData VALUES(50,0,3,'Outdoor Duty','OD','LOC','Check-In/Check-Out location',0)

--ALTER TABLE GPSLocationDetail ADD Location NUMERIC(5) DEFAULT 0
--UPDATE GPSLocationDetail SET Location = 0 WHERE Location IS NULL


