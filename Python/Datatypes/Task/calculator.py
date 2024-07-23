import arithmetic

print('Choose operation')
print('1.Addition\n2.Subtration\n3.Multiplication\n4.Division')
select = int(input('Select 1/2/3/4'))

def main():
    num01 = int(input('Enter 1st num'))
    num02 = int(input('Enter 2st num'))

    if(select == 1):
        Ans = arithmetic.Addition(num01,num02)
        print(f'Addition {num01} and {num02}:',Ans)
    elif(select == 2):
        Ans = arithmetic.Subtraction(num01,num02)
        print(f'Subtration {num01} and {num02}:',Ans)
    elif(select == 3):
        Ans = arithmetic.Multiplication(num01,num02)
        print(f'Mutiplication {num01} and {num02}:',Ans)
    elif(select == 4):
        Ans = arithmetic.Division(num01,num02)
        print(f'Division {num01} and {num02}:',Ans)
    else:
        print('choose 1/2/3/4')

if __name__=="__main__":
    main()