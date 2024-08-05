# def sum_all(*args):
#     count=0
#     for i in args:
#         count+=i
#     return count
# output=sum_all(1,2,3,4,5)
# print('addition:',output)

# def namelist(*args):
#     for i in args:
#      print(i)
# def main():
#     names=['nirmal','ikfan','sanjai','sandhya','sindhuja']

#     namelist(*names)

# if __name__=="__main__":
#     main()


def staffdetails(**kwargs):
    for key,value in kwargs.items():
        print(f'{key} is {value}')
def main():
    changepond = {'Name':'Nirmal',
                  'Age':24,
                  'MobileNo':7550064411
                 }
    staffdetails(**changepond)
if __name__ =="__main__":
    main()