def Addition(value1, value2):
    Ans = value1+value2
    return Ans

def Subtraction(value1, value2):
    Ans = value1-value2
    return Ans

def Multiplication(value1, value2):
    Ans = value1*value2
    return Ans

def Division(value1, value2):
    Ans = value1/value2
    return Ans



def main():
    while True:
        operations={
            "1":Addition,
            "2":Subtraction,
            "3":Multiplication,
            "4":Division
        }
        print('Choose operation')
        print('1.Addition\n2.Subtration\n3.Multiplication\n4.Division\n5.exit')
        select = int(input('Select any option from 1/2/3/4:'))
  
        if(select == 1):
            num01 = int(input('Enter 1st num:'))
            num02 = int(input('Enter 2st num:'))
            Ans = operations["1"](num01,num02)
            print(f'Addition of {num01} and {num02}:',Ans)
        elif(select == 2):
            num01 = int(input('Enter 1st num:'))
            num02 = int(input('Enter 2st num:'))
            Ans = operations["2"](num01,num02)
            print(f'Subtration of {num01} and {num02}:',Ans)
        elif(select == 3):
            num01 = int(input('Enter 1st num:'))
            num02 = int(input('Enter 2st num:'))
            Ans = operations["3"](num01,num02)
            print(f'Mutiplication of {num01} and {num02}:',Ans)
        elif(select == 4):
            num01 = int(input('Enter 1st num:'))
            num02 = int(input('Enter 2st num:'))
            Ans = operations["4"](num01,num02)
            print(f'Division of {num01} and {num02}:',Ans)
        else:
            break

if __name__=="__main__":
    main()