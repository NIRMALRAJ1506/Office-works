from functools import reduce


def main():
    size=int(input('enter the size : '))

    lst=[]
    print("enter the values: ")

    for i in range(size):
        value=int(input())
        lst.append(value)
    print('the list is : ',lst)

    map_list=list(map(lambda num:num**3,lst))
    print('the map list is : ',map_list)
    print()
    reduce_list=reduce((lambda num1,num2:num1+num2),map_list)
    print('Reduce List:',reduce_list)
if __name__ =="__main__":
    main()