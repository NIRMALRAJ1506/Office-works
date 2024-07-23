DROP DATABASE dvdrental;

CREATE DATABASE dvdrental;

\l - list the database



SELECT * FROM CUSTOMERS;

SELECT FIRST_NAME FROM CUSTOMERS;

SELECT FIRST_NAME ||' '|| LAST_NAME,EMAIL FROM CUSTOMER LIMIT 20;

SELECT FIRST_NAME ||' '|| LAST_NAME "full name",EMAIL FROM CUSTOMER LIMIT 20;

TO CLEAR SCREEN \! cls

select first_name,last_name,email from customer order by first_name asc,last_name desc;


select email,length(email) as lenemail from customer order by lenemail desc;


create table sort_demo;

insert into sort_demo values
(1),
(2),
(3),
(null);

select distinct district from address;

select * from address where district='Lima';


Operators used with where clause
= -> Equal
> -> Greater than
< -> Less than
>= Greater than or equal
<= Less than or equal
<> or != Not equal
And -> Logical And operator
OR -> Logical Or operator
IN -> reeturns true if a value matches any values in the list
Between -> returns true if a value matches a pattern
is Null -> returns true if value is null
Not -> Negate the result of other operators



select last_name,first_name from customer where first_name='Jamie' and last_name='Rice';


select last_name,first_name from customer where first_name='Adam' or last_name='Rodriguez';


select last_name,first_name from customer
where first_name in ('Ann','Anne','Annie');


select last_name,first_name from customer
where first_name like 'Ann%';


select last_name,first_name,length(first_name) from customer
where first_name like 'A%'
and length(first_name) between 3 and 5;

select first_name,last_name from customer where
first_name like 'Bra%' and last_name <> 'Motley';


select title,length,rental_rate from film;


select title,length,rental_rate from film
where length>180
and rental_rate<1;

select title,length,rental_rate from film
where rental_rate>3
or rental_rate=0.99;

select film_id,title,release_year
from film
order by film_id limit 5;


select film_id,title,release_year
from film
order by film_id limit 1 offset 3;

select film_id,title,release_year
from film
order by film_id desc limit 5;


select film_id,title,release_year
from film
order by rating limit 5;

select film_id,title,release_year
from film
order by film_id
offset 5 rows
fetch first 5 row only;


select payment_id,amount,payment_date from payment where payment_date ::date in ('2007-02-15','2007-02-16');

select payment_id,amount,payment_date
from payment
where 
payment_date between '2007-02-15' and '2007-02-16';


select payment_id,amount,payment_date from payment where payment_date ::date not in ('2007-02-15','2007-02-16');

select first_name,last_name from customer where
first_name ~~ 'Dar%';

select first_name,last_name from customer where
first_name ~~* 'dar%';

select first_name,last_name from customer where
first_name ~~* 'Dar%';

select * from t where message like '%10$%%' escape '$';

select address,address2 from address where address2 is null;


select customer_id,sum(amount) from payment group by customer_id
order by sum(amount) desc;

select staff_id,count(payment_id) from payment group by staff_id;

select customer_id,sum(amount) from payment group by customer_id
having sum(amount)>200
order by sum(amount) desc;

select rating,special_features,count(release_year) from film group by cube(rating,special_features);

select rating,special_Features,count(release_year) 



select cust.customer_id,
cust.first_name,
cust.last_name,
p.amount,
p.payment_date
from customer cust
inner join payment p using(customer_id)
order by p.payment_date;



select cust.customer_id,
cust.first_name,
cust.last_name,
p.amount,
p.payment_date
from customer cust
inner join payment p using(customer_id)
inner join staff s using(staff_id)
order by p.payment_date;


select f.film_id, f.title, i.inventory_id
from film f 
left join inventory i 
using(film_id)
order by i.inventory_id desc


select e.first_name ||' '|| e.last_name "Employee",
m.first_name ||' '|| m.last_name "Manager" from employee e inner join employee m on m.employee_id=e.manager_id;

select e.first_name ||' '|| e.last_name "Employee",
m.first_name ||' '|| m.last_name "Manager" from employee e left join employee m on m.employee_id=e.manager_id;

select c.*,p.* from customer c full outer join payment p
on c.customer_id=p.customer_id;

select * from language cross join category;


select city from city where country_id in (
select country_id from country where country='Argentia');


select title from film where film_id in(
select film_id from film_category where category_id=(
select category_id from category where name='Action'));


select film_id,title,length,rating from film f
where length>(select avg(length) from film where rating = f.rating);


select first_name,last_name from staff
where staff_id=Any(select manager_staff_id from store);

select first_name,last_name from staff
where staff_id>Any(select manager_staff_id from store);


select customer_id,first_name,last_name from customer
where customer_id>All(select customer_id from rental where rental_id 
in (18,25))
order by customer_id;

select customer_id,first_name,last_name from customer c where
exists
(select 1 from payment p where p.customer_id = c.customer_id
and amount>11);


SELECT * FROM TOP_RATED_FILMS
UNION
SELECT * FROM MOST_POPULAR_FILMS;


SELECT * FROM TOP_RATED_FILMS
UNION ALL
SELECT * FROM MOST_POPULAR_FILMS;

SELECT * FROM TOP_RATED_FILMS
INTERSECT
SELECT * FROM MOST_POPULAR_FILMS;

SELECT * FROM TOP_RATED_FILMS
EXCEPT
SELECT * FROM MOST_POPULAR_FILMS;

select sum(
	case when rental_rate = 0.99 then 1 else 0 end 
)as "Economy",
sum(	
	case when rental_rate = 2.99 then 1 else 0 end 
)as "Mass",
sum(
	case when rental_rate = 4.99 then 1 else 0 end 
)as "Premium"
from film;


select title,rating,
case rating
	when 'G' then 'General Audiences'
	when 'PG' then 'Parental Guidance suggested'
	when 'PG-13' then 'Parents Guidance Suggested'
	when 'R' then 'Restricted'
	when 'NC-17' then 'Adults Only'
	End rating_description 
from film;	


select sum(
	case when rating = 'G' then 1 else 0 end 
)as "General Audiences",
sum(
	case when rating = 'PG' then 1 else 0 end 
)as "Parental Guidance suggested", 
sum(
	case when rating = 'PG-13' then 1 else 0 end 
)as "Parents caution Suggested",
sum(	
	case when rating = 'NC-17' then 1 else 0 end 
)as "Adults Only",
sum(
	case when rating = 'R' then 1 else 0 end 
)as "Restricted"
from film;


create sequence order_item_id
start 10
increment 10
minvalue 10
owned by order_details.item_id;


insert into order_details(order_id,item_id,item_Text,price)
values
(100,nextval('order_item_id'),'DVD Player',100),
(100,nextval('order_item_id'),'Android TV',500),
(100,nextval('order_item_id'),'Speaker',150),
(default,nextval('order_item_id'),'Min Wifif',300);


create table color(
color_id int generated by default as identity
(start with 10 increment by 10),
color_name varchar not null
);


insert into color(color_name) values ('Red');
insert into color(color_name) values ('Purple');


create table contacts(
id serial primary key,
first_name varchar(50) not null,
last_name varchar(50) not null,
full_name varchar(101) generated always as (first_name || ' ' ||
last_name)stored,
email varchar(300) unique
);

insert into contacts(first_name,last_name,email)
values
('Nirmal','Raj','nirmal@gmail.com'),
('Nisan','Nisin','nisinsan@gmail.com')
returning *;


