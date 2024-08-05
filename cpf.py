# Online Python compiler (interpreter) to run Python online.
# Write Python 3 code in this online editor and run it.
cpf = "40915113848"
































e = 0
y = [int(c) for c in cpf]
u = y[:-2]
h = y[-2:]
for c in range(len(u)):
    e += u[c]*(10-c)
w = e%11
fv1 = True
fv2 = True
if w < 2:
    fv1 = h[0] == 0
    fv2 = h[1] == 0
else:
    t = 11-w
    fv1 = t == h[0]
    fv2 = t == h[1]
    print(w,t)
print("fv1 =",fv1)
print("fv2 =",fv2)