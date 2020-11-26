# create database systemmanagecar;
# create table systemmanagecar.vehicle
# (
#     Name             varchar(100) null,
#     ID               int          not null
#         primary key,
#     branch           varchar(100) null,
#     costperday       int          null,
#     numberOilNow     int          null,
#     sizeOil          int          null,
#     numberKilometers int          null,
#     stateUsed        tinyint(1)   null,
#     maintain         tinyint(1)   null
# );
#
#
#
#
# create table systemmanagecar.car
# (
#     ID      int                                                                        not null
#         primary key,
#     TYPECAR enum ('MICRO', 'SEDAN', 'CUV', 'SUV', 'HATCHBACK', 'SUPERCAR', 'ROADSTER') null,
#     constraint car_ibfk_1
#         foreign key (ID) references systemmanagecar.vehicle (ID)
# );
# create table systemmanagecar.truck
# (
#     ID        int                                     not null
#         primary key,
#     TYPETRUCK enum ('NINITRUCK', 'TRUCK', 'BIGTRUCK') null,
#     constraint truck_ibfk_1
#         foreign key (ID) references systemmanagecar.vehicle (ID)
# );
#
#
# create table systemmanagecar.recordservice
# (
#     IDVEHICLE        int          not null,
#     ID               int          not null,
#     DATESERVICE      date         null,
#     numberKilometers int          null,
#     ERROR            varchar(100) null,
#     primary key (ID, IDVEHICLE),
#     constraint recordservice_ibfk_1
#         foreign key (IDVEHICLE) references systemmanagecar.vehicle (ID)
# );
#
# create index IDVEHICLE
#     on systemmanagecar.recordservice (IDVEHICLE);
# create table systemmanagecar.rentcontract
# (
#     IDCONTRACT    int          not null
#         primary key,
#     IDVEHICLE     int          null,
#     NAMECUSTORMER varchar(100) null,
#     EMAIL         varchar(100) null,
#     ADDRESS       varchar(100) null,
#     CAREER        varchar(100) null,
#     STARTDATE     varchar(100) null,
#     ENDDATE       varchar(100) null,
#     TOTALBILL     int          null,
#     BIRTHDAY      varchar(100) null,
#     constraint rentcontract_ibfk_1
#         foreign key (IDVEHICLE) references systemmanagecar.vehicle (ID)
# );
alter table rentcontract
add IDINSURANCE int;
create table insurance (
	ID int,
    TYPEINSURANCE enum('WOOD','IRON','SILVER','GOLD','DIAMOND'),
    IDCONTRACT int not null,
	FOREIGN KEY (IDCONTRACT) REFERENCES rentcontract(IDCONTRACT)
);
alter table insurance rename column ID to IID;
use systemmanagecar;
alter table vehicle
add column Description  text default  null;

Update vehicle set Name=@Name,branch=@Branch,costperday=@costperday,numberKilometers=@kilometer,vehicle.Description=@Descripton,stateUsed=@statususe,
                   ,maintain=@maintain
where ID=@ID;
select T.TYPETRUCK V.Name, V.ID, V.branch, V.costperday, V.stateUsed, V.maintain, t.TYPETRUCK from vehicle V, TRUCK T where v.id = T.id;