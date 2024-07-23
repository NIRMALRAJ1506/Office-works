#Creating a set
staff_id={123,124,125,126}#same data type
mixed_type={'Nirmal',25,124,True,124}#mixed data type
print('Set:',mixed_type)
print('Length:',len(mixed_type))


s1={True,0,1,False}
print(s1)
#True 1
#False 0

s1={True,1}
print(s1)

#task->iterate using for loop
mixed_type={'Nirmal',25,124,True,124}
for i in mixed_type:
    print(i)