
def main():
    size=int(input('Enter the size:'))
    lst=[]
    print('enter values:')
    for i in range(size):
        value=int(input())
        lst.append(value)
    print('User List:',lst)
    
    filter_list=list(filter(lambda x: 70 <= x <= 90,lst))
    print('Filter List:',filter_list)
    
if __name__=="__main__":
    main()