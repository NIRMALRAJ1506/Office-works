def display_menu(menu):
    print('Menu items are as below:')
    for menu_items in menu:
        print(menu[menu_items])
def add_menu(menu):
    print("Enter the starter you want to add")
    starter=input()
    key=input("Enter the key:")
    menu.update({key:starter})
    print("Starter Added Successfully")
    display_menu(menu)
def update_menu(menu):
    print('Enter the item to be updated')
    old_item=input()
    key_to_update = ""
    for key, value in menu.items():
        if value == old_item:
            key_to_update = key
            break
    if key_to_update in menu:
        print('Enter the new item name')
        new_item=input()
        menu[key_to_update]=new_item
        print('Starter Updated Successfully')
    display_menu(menu)
def delete_menu(menu):
    print('Enter the item to be deleted')
    del_item=input()
    key_to_delete= ""
    for key, value in menu.items():
        if value == del_item:
            key_to_delete = key
            break
    menu.pop(key_to_delete)
    print('Menu items after deleting:')
    display_menu(menu)
    
def main():    
    veg_starter={
        "food1":"paneer 65",
        "food2":"chilly paneer",
        "food3":"veg crispy"
        }
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