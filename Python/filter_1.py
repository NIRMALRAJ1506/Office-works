def check_number(number):
    if(number>=70 and number<=90):
        return number
def main():
    size=int(input('Enter the size:'))
    lst=[]
    print('enter values:')
    for i in range(size):
        value=int(input())
        lst.append(value)
    print('User List:',lst)
    
    filter_list=list(filter(check_number,lst))
    print('Filter List:',filter_list)
    
if __name__=="__main__":
    main()