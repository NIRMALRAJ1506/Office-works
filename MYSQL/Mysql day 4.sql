1.Delimiter $$

create procedure getCustomers()
begin
select customerName,city,state,
postalcode,country from customers
order by customerName;
end $$


delimiter ;

call getCustomers();


2.delimiter $$

create procedure createPerson()
begin
    drop table if exists persons;
    
    create table persons (
        id int auto_increment primary key,
        first_name varchar(255) not null,
        last_name varchar(255) not null
    );

    insert into persons (first_name, last_name)
    values
    ('Nirmal', 'Raj'),
    ('Sandhya', 'Suresh'),
    ('Mohamed', 'Ikfan'),
    ('Joseph', 'Vijay');

    select id, concat(first_name, ' ', last_name) as `Person Name` 
    from persons;
end $$


delimiter ;






3.delimiter //

create procedure getOfficeByCountry(IN countryName varchar(255))
begin
select * from offices where country=countryName;
end //

delimiter ;


4.delimiter //

drop procedure if exists GetOrderCountByStatus;

CREATE PROCEDURE GetOrderCountByStatus(IN orderstatus VARCHAR(255), out total int)
BEGIN
select count(orderNumber) into total From orders 
where status = orderstatus;
end //

delimiter ;



5.select routine_name from information_schema.routines
where routine_type = 'PROCEDURE'
and routine_schema = 'classicmodels';


----------------------------------------------------------------------------------------------------------------------------

delimiter $$

create procedure getCustomerLevel(
in pcustomernumber int,
out pcustomerlevel varchar(20)
)
begin
declare credit decimal(10,2) default 0;
select creditlimit into credit
from customers where customernumber = pcustomernumber;

if credit>50000 then
set pcustomerlevel="PLATINUM";
elseif credit<=50000 and credit>10000 then
set pcustomerlevel="NON-PALTINUM";
else
set pcustomerlevel="SILVER";
end if;

end $$

delimeter ;





delimiter $$

create procedure getCustomerShipping(
in pcustomernumber int,
out pcustomercountry varchar(20)
)
begin
declare customercountry varchar(100);
select country into customercountry
from customers where customernumber = pcustomernumber;

case customercountry
when 'USA' then
set pshipping = '2-DAY SHIPPING';
when 'CANADA' then
set pshipping = '3-DAY SHIPPING';
when 'Belgium' or 'Italy' then
set pshipping = '4-DAY SHIPPING';
else
set pshipping = '5-DAY SHIPPING';
end case;

end $$

delimeter ;








delimiter $$

CREATE PROCEDURE getDeliveryStatus(
    IN porderNumber INT,
    OUT deliverystatus VARCHAR(100)
)
BEGIN
    DECLARE deliveryvalue INT;

    SELECT DATEDIFF(requireddate, shippeddate) INTO deliveryvalue
    FROM orders
    WHERE ordernumber = porderNumber;

    IF deliveryvalue < 0 THEN
        SET deliverystatus = 'On Time';
    ELSEIF deliveryvalue IS NULL THEN
        SET deliverystatus = 'Insufficient';
    ELSE
        SET deliverystatus = 'Delayed';
    END IF;
END $$


delimiter ;

---------------------------------------------------------------------------------------------------------------------------
create table calenders(
date Date primary key,
month int not null,
quarter int not null,
year int not null
);


drop procedure if exists loadDates;


delimiter $$
create  procedure loadDates(startdate Date,day int)
begin
declare counter int default 0;
declare currentDate Date default startdate;

while counter <=day Do
	call InsertCalender(currentDate);
	set counter = counter + 1;
	set currentDate=date_add(currentDate,INTERVAL 1 day);
end while;

end$$
delimiter ;


delimiter $$
create procedure InsertCalender(currentDate Date)
begin
insert into calenders(date,month,quarter,year)
values(
currentDate,month(currentDate),
quarter(currentDate),year(currentDate)
);
end $$
delimiter ;



