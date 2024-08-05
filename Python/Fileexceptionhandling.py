import os

def fileread(file1):
    file = None
    try:
        file = open(file1, 'r')
        content = file.read()
        print(content)
    except FileNotFoundError:
        print(f"Error: File '{file1}' not found.")
    except PermissionError:
        print(f"Error: Permission denied to read file '{file1}'.")
    except IOError as e:
        print(f"Error: An I/O error occurred while reading the file '{file1}': {e}")
    finally:
        if file:
            file.close()

def filewrite(file1, file_write):
    file_read = None
    new_file = None
    try:
        file_read = open(file1, 'r')
        new_file = createfile(file_write)
        if new_file:
            new_file.write(file_read.read())
    except FileNotFoundError:
        print(f"Error: File '{file1}' not found.")
    except PermissionError:
        print(f"Error: Permission denied to read file '{file1}' or write to file '{file_write}'.")
    except IOError as e:
        print(f"Error: An I/O error occurred: {e}")
    finally:
        if file_read:
            file_read.close()
        if new_file:
            new_file.close()

def createfile(filename):
    if os.path.exists(filename):
        print(f"Error: File '{filename}' already exists.")
        return None
    else:
        try:
            file_create = open(filename, 'w')
            return file_create
        except PermissionError:
            print(f"Error: Permission denied to create file '{filename}'.")
        except IOError as e:
            print(f"Error: An I/O error occurred while creating the file '{filename}': {e}")
        return None

def main():
    file1 = input('Enter the file name to read: ')
    file_name = input('Enter the file name you want to create: ')
    
    if file_name:
        filewrite(file1, file_name)
    else:
        print("Error: No file name provided for creating the file.")

if __name__ == "__main__":
    main()
