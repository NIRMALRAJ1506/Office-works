def Outer():
    print('Inside Outer')

    def Inner():
        print('Inside Inner')
    print('Inner:',id(Inner))

    return Inner
Result=Outer()
print('Result:',id(Result))
Result()
