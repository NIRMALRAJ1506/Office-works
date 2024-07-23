def main():
    name=input("Enter the string:")
    special_characters = ['~', ':', "'", '+', '[', '\\', '@', '^', '{', '%', '(', '-', '"', '*', '|', ',', '&', '<', '`', '}', '.', '_', '=', ']', '!', '>', ';', '?', '#', '$', ')', '/']
    check=False
    for i in name:
        if i in special_characters:
            check=False
            print("String has special characters")
            break
        else:
            check=True
    if check:
        print("String has no special characters")

if __name__=="__main__":
    main()