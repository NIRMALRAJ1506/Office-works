#Creating a list:
#Creating same data types
course=['Python','Java','PHP'] #string
rollno=[123,124,125] #integer

#Creating mixed type/heterogenous
mixed_type=['Nirmal',123,True,67.78]
print('Heterogenous:',mixed_type)
print('Length',len(mixed_type))
print('Access value of Nirmal:',mixed_type[0])
print('Access value of 123:',mixed_type[1])
print('Access value of true:',mixed_type[2])
print('Access value of 67.78:',mixed_type[3])

# slicing
print('Slicing:',mixed_type[1:3])

print('Slicing:',mixed_type[-4:-1])

#Mutable (can change adda and delete)
fruits=['Mango','Banana','Grapes','WaterMelon']
fruits[1]='Strawberry'
print('Using Index replacing banana with strawberry',fruits)


del fruits[3]
print('Removing watermelon:',fruits)

fruits[1:3]=['Gauva','Jackfruit']
print('After replacing',fruits)