from z3 import *
maxR = 8
arr = [-47,
          -86,
          -107,
          -101,
          -83,
          -41,
          -80,
          -82,
          13,
          9,
          -22,
          -82,
          -68,
          -81,
          -91,
          -49,
          -80,
          -80,
          -71,
          -87,
          -30,
          0,
          -36,
          -97,
          -12,
          -61,
          -101,
          -67,
          -94,
          -75,
          -26,
          -15]
errorMes = "Index was outside the bounds of the array"
def xor2(letra1,letra2):
    return ord(letra1) ^ letra2
def xor(letra):
    return b'11111111' ^ ord(letra)
    #return 0xFFFF - 1 - ord(letra)

#for i in range(maxR):
#globals()['token%i' % i]=BitVec('token%i' %i,32)
flag = [BitVec('token%i'%i,8) for i in range(0,maxR)]
s = Solver()
print(flag[1]^errorMes[0])
"""
for i in range(maxR):
    s.add(flag[i] >= ord('A'), flag[i] <= ord('z'))
    s.add( flag[i%8] ^ errorMes[i] + arr[i] >= 33)
    s.add( flag[i%8] ^ errorMes[i] + arr[i] <= 126)
    #s.add(xor2(globals()['token%i' %(i % 8)],ord(errorMes[i])) + arr[i] >= ord('A'))
    #s.add(xor2(globals()['token%i' %(i % 8)],ord(errorMes[i])) + arr[i]<= ord('z'))
s.add( flag[1] ^ errorMes[0] + arr[0] >= ord('h'))

if s.check() == sat:
    values =s.model()
    valor = ''
    for i in range(maxR):
        obj = globals()['token%i' %i]
        char = values[obj].as_long()
        valor += chr(char)
    print(valor)
else:
    print('nooo')"""