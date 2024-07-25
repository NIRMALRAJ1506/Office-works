new_list=[i for i in range(1,11)]
print('List Comprehension:',new_list)

new_list=[i for i in range(1,11) if(i%2==0)]
print('List Comprehension:',new_list)

name="Nirmal Raj"
vowels_list=[name[i] for i in range(len(name)) if name[i]  in ('a','e','i','o','u','A','E','I','O','U')]
print('List Comprehension:',vowels_list)

