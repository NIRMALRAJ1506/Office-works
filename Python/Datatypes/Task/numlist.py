def addition(numlist):
    sum=0
    for i in range(len(numlist)):
        sum+=numlist[i]
    print("Addition of all the values in the list:",sum)

def maximum(numlist):
    max=0
    for i in range(len(numlist)-1):
        if numlist[i]>numlist[i+1]:
            max=numlist[i]
        else:
            max=numlist[i+1]
    print("Maximum value in the list is:",max)
def main():
    num_list=[]
    size=int(input("enter the size of the list:"))
    for i in range(size):
        print("enter the values of the list:")
        value=int(input())
        num_list.append(value)
    addition(num_list)
    maximum(num_list)
if __name__=="__main__":
    main()