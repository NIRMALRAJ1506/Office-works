import os
def fileread(file1):
    file_read=open(file1,'r')
    print(file_read.read())
def filewrite(file1,file_write):
    file_read=open(file1,'r')
    new_file=createfile(file_write)
    new_file.write(file_read.read())


def createfile(filename):
    if(os.path.exists(filename)):
        print("File Already Exists")
    else:
        file_create=open(filename,'w')
        return file_create


def main():
    file1=input('Enter the file name to read:')
    print('Enter the file name you want to create:')
    file_name=input()
    
    filewrite(file1,file_name)
if __name__=="__main__":
    main()