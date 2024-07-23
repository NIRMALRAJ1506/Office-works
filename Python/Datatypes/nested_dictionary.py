users={
    'nirubag':{
        'firstname':'Nirmal',
        'lastname':'Raj',
        'Location':'Chennai'
    },
    'rajubag':{
        'firstname':'Mohamed',
        'lastname':'Ikfan',
        'Location':'Chennai'
    },
    'nisanbag':{
        'firstname':'Sandhya',
        'lastname':'Suresh',
        'Location':'Chennai'
    },
}
for user in users:
    print(f'{user}:{users[user]}')

print(users['nirubag']['firstname'])
print(users['nirubag']['Location'])