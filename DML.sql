use systemmanagecar;

insert into VEHICLE(ID,NAME,branch,costperday,stateUsed,maintain) VALUE (2,'Vinfast Lux SA2.0','Vinfast','10000000',false,false);
insert into car(ID,TYPECAR)VALUE(2,'SUV');
insert into VEHICLE(ID,NAME,branch,costperday,stateUsed,maintain) VALUE (3,'Vinfast Lux V8 President ','Vinfast','10000000',false,false);
insert into car(ID,TYPECAR)VALUE(3,'SEDAN');
insert into VEHICLE(ID,NAME,branch,costperday,stateUsed,maintain) VALUE (4,'Mercedes Benz','Mercedes Benz','10000000',false,false);
 insert into car(ID,TYPECAR)VALUE(4,'SUV');
insert into VEHICLE(ID,NAME,branch,costperday,stateUsed,maintain) VALUE (5,'Mercedes C300','Mercedes Benz','10000000',false,false);
insert into car(ID,TYPECAR)VALUE(5,'SEDAN');
insert into VEHICLE(ID,NAME,branch,costperday,stateUsed,maintain) VALUE (6,' Toyota Corolla Altis','Toyota','10000000',false,false);
insert into car(ID,TYPECAR)VALUE(6,'CUV');
insert into VEHICLE(ID,NAME,branch,costperday,stateUsed,maintain) VALUE (7,'Toyota Vios ','Toyota','10000000',false,false);
insert into car(ID,TYPECAR)VALUE(7,'ROADSTER');
(select V.Name, V.ID,V.branch,V.costperday,V.stateUsed,V.maintain,c.TYPECAR from vehicle V, car c where v.id=c.id)
union
(select V.Name, V.ID,V.branch,V.costperday,V.stateUsed,V.maintain,t.TYPETRUCK from vehicle V, TRUCK T where v.id=T.id)  ;
insert into VEHICLE(ID,NAME,branch,costperday,stateUsed,maintain) VALUE (8,'Mercedes Benz 1.0','Mercedes Benz','10000000',true,true);
 insert into car(ID,TYPECAR)VALUE(8,'SEDAN');
 insert into VEHICLE(ID,NAME,branch,costperday,stateUsed,maintain) VALUE (9,'Mercedes Benz 2.0','Mercedes Benz','10000000',false,true);
 insert into car(ID,TYPECAR)VALUE(9,'SEDAN');

 insert into rentcontract(IDCONTRACT,IDVEHICLE,NAMECUSTORMER,EMAIL,ADDRESS,STARTDATE,ENDDATE,TOTALBILL)VALUE(2,2,"LE TUAN VU","LETUANVU@GMAIL.COM","KTX","11/11/2020","12/11/2020",100000);
select * from rentcontract RC join insurance I on RC.IDCONTRACT = I.IDCONTRACT, vehicle V, car C where RC.IDVEHICLE = V.ID and V.ID = C.ID;
insert into  insurance(IID, TYPEINSURANCE, IDCONTRACT) values (@ID,@TYPE,@IDCONTRACT);
alter table rentcontract
DROP COLUMN PHONE,
ADD PHONENUMBER TEXT;