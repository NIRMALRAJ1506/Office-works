def order_sandwich(*args):
    ordered_sandwiches={}
    order=input("Enter The Sandwich you want to order:")
    
    if order in args:
        ingredient_list=[]
        while True:
            ingredients = input("Enter Ingredient (or type 'done' to finish): ").strip()
                
            # Check if user wants to finish
            if ingredients.lower() == 'done':
                break
            
            # Add ingredient to list
            ingredient_list.append(ingredients)
    ordered_sandwiches[order]=ingredient_list

    print("Your Order:")
    for key,value in ordered_sandwiches.items():
        print(f'order:{key} Ingredients:{value}')
        
    
def main():
    sandwiches = [
    'Veg Sandwich',       
    'Chicken Sandwich',    
    'Grilled Cheese Sandwich',      
    'Peanut Butter and Jelly Sandwich', 
    'Ham Sandwich'        
]
    order_sandwich(*sandwiches)

if __name__=="__main__":
    main()
