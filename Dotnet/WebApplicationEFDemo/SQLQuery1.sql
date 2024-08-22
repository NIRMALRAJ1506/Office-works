alter table Employee with check add constraint fk_emp_dept foreign key (DepartmentId) references
Department(id)