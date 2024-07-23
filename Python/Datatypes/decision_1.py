num=int(input('enter Your Number:'))
if(num%2==0):
    print(f'{num} is even')
else:
    print(f'{num} is not even')
print()
days=int(input('Enter the day between 1 to 7:'))
if(days==1):
    print('Monday we will be learning datatypes')
elif(days==2):
    print('Tuesday we will be learning Functions')
elif(days==3):
    print('Wednesday we will be learning string')
elif(days==4):
    print('Thursday we will be learning list')
elif(days==5):
    print('Friday we will be learning set')
elif(days==6):
    print('Saturday we will be learning dictionary')
elif(days==7):
    print('Sunday we will be learning tuple')
else:
    print('Invalid')

