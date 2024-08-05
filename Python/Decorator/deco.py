def sub(n1,n2):
    ans = n1-n2
    return ans

def decorated_function(function_name):
    # print(1)
    def inner(a,b):
        # print(3)
        if(a<b):
            a,b = b,a
        output = function_name(a,b)
        return output
    # print(2)
    return inner

def main():
    num1 = int(input('Enter the First number : '))
    num2 = int(input('Enter the sec Number : '))

    new_func = decorated_function(sub)
    result = new_func(num1,num2)
    print(result)

if __name__ == '__main__':
    main()

    