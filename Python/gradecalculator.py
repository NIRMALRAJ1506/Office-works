def calculate_input():
    marks = {}
    marks["Python"] = int(input("Enter the Python Mark:"))
    marks["HTML CSS"] = int(input("Enter the Cloud Computing Mark:"))
    marks["React"] = int(input("Enter the Cyber Security Mark:"))
    marks["Javascript"] = int(input("Enter the Network_security Mark:"))
    marks["Angular"] = int(input("Enter the Angular Mark:"))
    return marks
 
def calculate_grads(marks,result):
    final = sum(marks.values())
    if final >= 400:
        return result[400]
    elif final <=399 and final >=300:
        return result[300]
    elif final <=299 and final >=200:
        return result[200]
    elif final < 200:
        return result[100]
def main():
    result = {
        400:"Your Grade: O :)",
        300:'Your Grade: A',
        200:"Your Grade: B",
        100:'Your Grade: F'}
   
    marks = calculate_input()
    print()
    print("________Result_________")
    print(calculate_grads(marks,result))
if __name__ == "__main__":
    main()