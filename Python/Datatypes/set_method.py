mixed_type={'Nirmal',25,124,True}
more_add={'Raj',24}
#add() method-> add element to the set
mixed_type.add('Trainee')
print('Add method:',mixed_type)

#update() method
mixed_type.update(more_add)
print('Update Method:',mixed_type)

#discard() method -> remove the specified element 
mixed_type.discard('Trainee')
print('Discard Method:',mixed_type)

# mixed_type.remove('Trainer')
# print('Discard Method:',mixed_type)