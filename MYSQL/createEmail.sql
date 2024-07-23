drop procedure if exists create_email_list;

delimiter $$

DROP PROCEDURE IF EXISTS Create_Email_List;

CREATE PROCEDURE Create_Email_List(inout email_list TEXT)
BEGIN
   
   declare email_address varchar(100) default "";
   declare done bool default false;
   
   declare cur_email_list CURSOR for select email from employees;
   
   declare CONTINUE HANDLER
	FOR NOT FOUND SET done = true;
	
	OPEN cur_email_list;
	
	set email_list= ' ';
	process_email : LOOP
		FETCH cur_email_list into email_address;
		if done = true THEN
			LEAVE process_email;
		end if;
		set email_list = concat(email_address," ",email_list);
	END LOOP;
	
	CLOSE cur_email_list;
 
END $$

delimiter ;