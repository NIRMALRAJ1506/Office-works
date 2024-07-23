# Create a tuple
#Homogenous
student_id=(123,124,125,126)
ice_cream=('Vanilla','Chocolate','BlueBerry')

#Heterogenous
mixed_type=(123,'Hello',False,56.78)
#len()
# using index==>Blueberry(Positive index)
# using index==>False(Negative index)
# using slicing==>'Hello',False

# print("length of student id ",len(student_id))
# print("value of positive index ",ice_cream[2])
# print("value of negative index ",mixed_type[-2])
# print("Slicing ",mixed_type[1:3])


# ice_cream=('Vanilla')
# print(ice_cream,type(ice_cream))
# ice_cream=('vanilla',)#comma (tuple)
# print(ice_cream,type(ice_cream))

# immutable
#mixed_type[0] = True
#print("False ",mixed_type)

ice_cream=('Vanilla','Choco-chips','Blueberry','Vanilla')
countermethod=ice_cream.count('Vanilla')
print('Counter Method:',countermethod)
print()
indexmethod=ice_cream.index('Vanilla')
print('Index Method:',indexmethod)
