// Exercício do curso Nélio Alves "Vetores A B C"
// Esse programa será criado 3 vetores, o usuário ir digitar uma quantidade "N" ´de números nos Vetores A e B.
// Em seguida o programa mostrará no vetor C a soma do vetor A e B;

int N = int.Parse(Console.ReadLine());
int [] A = new int[N];
int [] B = new int[N];
int [] C = new int[N];
string [] X = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    A[i] = int.Parse(X[i]);
}
string [] Y = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    B[i] = int.Parse(Y[i]);
}
for (int i = 0; i < N; i++)
{
    C[i] = A[i] + B[i];
    Console.Write(C[i] + " ");
}