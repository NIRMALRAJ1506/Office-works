# menu_card=['Paneer','Idli','Rice']
# print('Available Items in menu card:',menu_card)

# #append()-->Adds an element at the end of the list
# menu_card.append('Dosa')
# print('After using append method:',menu_card)
# #Poori Briyani
# #extend()-->Adds an element at the end of the list
# menu_card.extend(['Poori','Briyani'])
# print('Using Extend method:',menu_card)
# # insert-->Addsa an element specified position
# menu_card.insert(1,'Veg Briyani')
# print('Using Insert Method',menu_card)
# # remove() method removes the specified value
# menu_card.remove('Idli')
# print('Using Remove Method:',menu_card)
# # pop() method removes the element of specified position
# menu_card.pop(2)
# # print('Using POP method:',menu_card)

menu_card=['Paneer','Dal','Rice']
# index method
index_method=menu_card.index('Dal')
print('It will give position:',index_method)

index_method=menu_card.index('Rice')
print('It will give position:',index_method)
# sort method
menu_card.sort()
print('After Sorting:',menu_card)