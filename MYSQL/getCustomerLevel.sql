delimiter $$
DROP FUNCTION if EXISTS GetCustomerLevel;

CREATE FUNCTION GetCustomerLevel(credit DECIMAL(10,2))
RETURNS VARCHAR(20)
DETERMINISTIC
BEGIN


	declare customerlevel varchar(20);
	
	if credit > 50000 THEN
		set customerlevel = "PLATINUM";
	elseif credit <= 50000 and credit > 10000 THEN
		set customerlevel = "GOLD";
	ELSE
		set customerlevel = "SILVER";
	END IF;

	RETURN(customerlevel);
END $$
delimiter ;


SELECT customerName, GetCustomerLevel(creditLimit) FROM customers;