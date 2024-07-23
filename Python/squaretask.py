import math
def square(list,size):
   
    for i in range(size):
        print("Enter the numbers to be stored in the list")
        num=int(input())
        value=num**2
        list.append(value)
    print(list)

def main():
    squarenumlist=[]
    size=int(input('Enter the size of the list'))
    
    square(squarenumlist,size)       
if __name__=="__main__":
    main()
