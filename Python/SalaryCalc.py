class Salary:
    def __init__(self,basesal):
        self._basesal=basesal
    def getsalary(basesal):
        return basesal

class Allowance(Salary):
    def __init__(self,basesal):
      
        self._HRA=0.2 * basesal
        self._DA=0.4 * basesal
        self._TA=0.25 * basesal
        self._allowance=self._HRA+self._DA+self._TA
    def getAllowances(self):
        return self._allowance
class Deductions(Salary):
    def __init__(self,basesal):
         super().__init__(basesal)
         self._Insurance=5000
         self._PF=0.12 * basesal
         self._Gratuity = self._basesal * 0.05
    def getDeductions(self):
        return self._Insurance+self._PF+self._Gratuity
class CalculateSalarySlip(Allowance,Deductions):
    def __init__(self,basesal):
        Allowance.__init__(self, basesal)  
        Deductions.__init__(self, basesal)
        self._basesal=basesal
        self._allowance=super().getAllowances()
        self._deductions=super().getDeductions()
        self._grosssalary=self._basesal+self._allowance
        self._netsalary=self._grosssalary-self._deductions
    def getSalarySlip(self):
        print("Basic Salary is:",self._basesal)
        print("Allowances is:",self._allowance)
        print("Deductions is:",self._deductions)
        print("Gross Salary is:",self._grosssalary)
        print("Net Salary is:",self._netsalary)

cs=CalculateSalarySlip(10000)
cs.getSalarySlip()


    