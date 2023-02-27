#include <iostream>
#include <stdlib.h>
using namespace std;
class Taibe
{
    int dydis, kiekis, riba;
    int* p;
public:
    Taibe(int max, int n);
    ~Taibe() { delete[]p; }
    int arYra(int x);
    void trink(int x);
    int kiek();
    int papildyk(int x);
    void rodyk();
};
Taibe::Taibe(int max, int n)
{
    riba = max;
    kiekis = 0;
    p = new int[dydis = n];
}
int Taibe::arYra(int x)
{
    int i = kiekis - 1;
    if (!kiekis) return 0;
    while ((i > 0) && (x != p[i]))
    {
        i--;
    }
    if (x == p[i])
        return 1;
    else
        return 0;
}
void Taibe::trink(int x)
{
    int i = kiekis - 1;
    while ((i > 0) && (x != p[i]))
    {
        i--;
    }
    if (x == p[i])
    {
        kiekis--;
        while (i < kiekis)
        {
            p[i] = p[i + 1];
            i++;
        }
    }
}
int Taibe::papildyk(int x)
{
    if ((kiekis + 1 > dydis) || (x > riba))
    {
        cout << "L aibe perpildyta.";
        return 0;
    }
    if (!arYra(x)) p[kiekis++] = x;
    return 1;
}
void Taibe::rodyk()
{
    int i;
    for (int i = 0; i < kiekis; i++)
    {
        cout << p[i];
        if (i != kiekis - 1)
            cout << ", ";
        else cout << ". ";
    }
}
int Taibe::kiek()
{
    return kiekis;
}
int main()
{
    int max, n, stop;
    cout << "Sukuriama aibe, kurios nariai atkarpos [1, M] sveikieji skaiciai." << endl;
    cout << "Suteikite reiksme M: "; cin >> max;
    cout << "Kiek bus aibes elementu: "; cin >> n;
    Taibe A(max, n);
    A.rodyk();
    stop = 1;
    while (stop != 0)
    {
        cout << "Koki skaiciu pradesime? " << endl;
        cin >> n;
        A.papildyk(n);
        A.rodyk();
        cout << "Aibeje yra " << A.kiek() << " elementai." << endl;
        cout << "Ar tesime ?"<<endl;
        cin >> stop;
    }
    stop = 1;
    while (stop != 0)
    {
        cout << "Koki skaiciu ieskosime? " << endl;
        cin >> n;
        if (A.arYra(n))
        {
            cout << "Yra" << endl;
        }
        else
            cout << "Nera" << endl;
        cout << "Ar tesime?" << endl;
        cin >> stop;
    }
    stop = 1;
    while (stop != 0)
    {
        cout << "kuri skaiciu trinsime?" << endl;
        cin >> n;
        A.trink(n);
        A.rodyk();
        cout << endl;
        cout << "Ar tesime?" << endl;
        cin >> stop;
    }
    return 0;
}
