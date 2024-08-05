class Product:

    product_id=0
    def __init__(self,pname,price,descr):
        self._pname=pname
        self._price=price
        self._descr=descr
        Product.product_id=Product.product_id+1
    def addproduct(self,product_details):

         product_details.update({Product.product_id:{'Name':self._pname,'Price':self._price,'description':self._descr}})

         return product_details
         
   
    def getproductdetails(self,product_details):
        print(product_details)
        disp=int(input("Enter the Product id to display : "))
        print("Product Id: ",disp)
        print(product_details.get(disp))
        print("Name :",product_details[disp]['Name'])
        print("Price :",product_details[disp]['Price'])
        print("Description :",product_details[disp]['description'])
        
          
product_details={}
while True:
    print("Enter the Choice to Perform\n1.Add Product\n2.Display\n.Exit")
    num=int(input("Enter the choice"))
    if num==1:
          pname=input("Enter the product name :")
          price=int(input("Enter the product price :"))
          description=input("Enter the product description :")
          c1=Product(pname,price,description)
          product_details.update(c1.addproduct(product_details))
    elif num==2:
         c1.getproductdetails(product_details)
    if num==3:
        print("Exited...")
        break 
    