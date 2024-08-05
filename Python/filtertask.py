def check_list(courses):
    if courses=='':
        return False
    special_char={'~', ':', "'", '+', '[', '\\', '@', '^', '{', '%', '(', '-', '"', '*', '|', ',', '&', '<', '`', '}', '.', '_', '=', ']', '!', '>', ';', '?', '#', '$', ')', '/'}
    for i in special_char:
        if i in courses:
            return False
    return True


def main():
    courses=['','python','java',',,','angu;lar','php']
    filter_list=list(filter(check_list,courses))
    print('Filter List:',filter_list)

if __name__=="__main__":
    main()