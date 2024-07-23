watch_details={
    'Titan':8000,
    'Fasttrack':5000,
    'Omega':9000,
    'Titan': 12000
}

key_method=watch_details.keys()
print('key method:',key_method)

value_method=watch_details.values()
print('Value method:',value_method)

#get method+>returns the value of specified key
get_method=watch_details.get('Titan')
print('get method:',get_method)

#items() method
item_method =watch_details.items()
print('item method:',item_method)

#update method => Insert an item to the dictionary
watch_details.update ({'Noise':12000})
print('Update Method:',watch_details)

#pop method=>remove element with the specified key
watch_details.pop('Titan')
print('Pop method:',watch_details)