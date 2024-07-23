select substr('Nirmalraj',6);
 substr
--------
 lraj



select concat('Sandhya','Nirmal Raj');
      concat
-------------------
 SandhyaNirmal Raj
(1 row)


select upper('Nirmalraj');
   upper
-----------
 NIRMALRAJ
(1 row)


select lower('Nirmalraj');
   lower
-----------
 nirmalraj
(1 row)


select length('Nirmalraj');
 length
--------
      9
(1 row)

SELECT first_name || ' ' || last_name FROM customer;

select * from customer
select * from film

-- INITCAP
select INITCAP(email)
 as "Using INITCAP() ", email from customer

-- ASCII
select ASCII(first_name) as "Using ASCII() ", first_name from customer

-- CHR
select CHR(customer_id) as "Using CHR() ", customer_id from customer

-- Lower
select Lower(first_name) as "Using Lower() ", first_name from customer

-- bit_length
select bit_length(first_name) as "Using bit_length() ", first_name from customer

-- char_length
select char_length(first_name) as "Using char_length() ", first_name from customer

-- overlay
select overlay(first_name placing 'Nirmal' from 2 for 4) as "Using overlay() ", first_name from customer

-- position
select position('a' in first_name) as "Using position() ", first_name from customer

-- substring
select substring(first_name from 1 for 3) as "Using substring(from 1 for 3	) ", first_name from customer


select 


