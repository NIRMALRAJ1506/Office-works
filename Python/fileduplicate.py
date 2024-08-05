import os
import filecmp
def comparefiles(filename1,filename2):
    if(not os.path.exists(filename1)):
        print('Not Exists:',filename1)
    elif(not os.path.exists(filename2)):
        print('Not Exists:',filename2)
    else:
        compare=filecmp.cmp(filename1,filename2)
        if compare==True:
            print("Success-> The files are same")
            print("Duplicate file deleted")
            os.remove(filename1)
        else:
            print("Failure-> The files are different")
def main():
    filename1=input("Enter the filename 1 name:")
    filename2=input("Enter the filename 2 name:")
    comparefiles(filename1,filename2)

if __name__=="__main__":
    main()