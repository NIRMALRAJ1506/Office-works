def appendfile(file,appfile):
    file1=open(file,'r')
    file2=open(appfile,'a')
    file_content=file1.read()
    file2.write(file_content)
def main():
    file_name=input("enter the file name:")
    append_file=input("enter the append file name:")
    appendfile(file_name,append_file)
if __name__=="__main__":
    main()