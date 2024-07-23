def display_menu(menu):
    print('Menu items are as below:')
    for menu_items in menu:
        print(menu_items)
def add_menu(menu):
    print("Enter the starter you want to add")
    starter=input()
    menu.append(starter)
    print('Menu items after adding:')
    display_menu(menu)
def update_menu(menu):
    print('Enter the item to be updated')
    old_item=input()
    if old_item in menu:
        print('Enter the new item name')
        new_item=input()
        index=menu.index(old_item)
        menu[index]=new_item
        print('Menu items after updating:')
    display_menu(menu)
def delete_menu(menu):
    menu.pop()
    print('Menu items after deleting:')
    display_menu(menu)
    
def main():    
    veg_starter=['paneer 65','chilly paneer','veg crispy']
    print("1.Display Mwnu\n2.Add menu\n3.Update menu\n4.delete menu")
    print('Enter The Options from 1 to 4')
    option=int(input())
    if(option==1):
        display_menu(veg_starter)
    elif(option==2):
        add_menu(veg_starter)
    elif(option==3):
        update_menu(veg_starter)
    elif(option==4):
        delete_menu(veg_starter)
    else:
        print("Invalid Option")
if __name__=="__main__":
    main()