import os

def removefile(rmv_file):
    if (os.path.exists(rmv_file)):
        os.remove(rmv_file)
    else:
        print("File does not exists")
def main():
    file_name=input("Enter the file name to be deleted:")
    removefile(file_name)
if __name__=="__main__":
    main()