company={'Infosys','ICCI bank','TCS','Bajaj'}
add_company={'SBI','Tata Consultancy','Infosys','TCS'}

union_method=company.union(add_company)
print('Union Method will return all the element:',union_method)
print()
union_method=company|add_company
print('Using Operator:',union_method)
print()
intersection_method=company.intersection(add_company) #operator &
print('Intersection method will return common elements:',intersection_method)
print()
difference_method=company.difference(add_company)
print('difference method:',difference_method)
print()
difference_method=company.difference(company)
print('difference method:',difference_method)
print()
symm_difference = company.symmetric_difference(add_company)
print('symm_difference: ',symm_difference)