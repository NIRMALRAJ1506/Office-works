create or replace view customerPayments
as
select customername,checknumber,paymentdate,amount
from customers
inner join
payments using(customernumber);