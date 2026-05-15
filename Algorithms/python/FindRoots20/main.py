import random

# =====================================================
# 1) 20. DERECE POLİNOM OLUŞTURMA
# =====================================================

def get_coefficients():
    print("1 -> Rastgele 20. derece polinom")
    print("2 -> Manuel giriş")

    choice = input("Seçim: ")

    coeffs = []

    if choice == "1":
        for i in range(21):
            coeffs.append(random.randint(-5, 5))

        if coeffs[0] == 0:
            coeffs[0] = 1

    elif choice == "2":
        print("\n20. derece katsayıları giriniz:")
        for i in range(21):
            power = 20 - i
            coeffs.append(float(input(f"x^{power}: ")))

    else:
        print("Hatalı seçim!")
        exit()

    return coeffs


# =====================================================
# 2) POLİNOMU YAZDIR
# =====================================================

def print_polynomial(c):

    print("\n================ POLİNOM =================\n")

    degree = len(c) - 1
    terms = []

    for i, coef in enumerate(c):

        power = degree - i

        if coef == 0:
            continue

        if power > 1:
            terms.append(f"({coef})x^{power}")
        elif power == 1:
            terms.append(f"({coef})x")
        else:
            terms.append(f"({coef})")

    print("f(x) = " + " + ".join(terms))
    print("\n==========================================\n")


# =====================================================
# 3) POLİNOM FONKSİYONU
# =====================================================

def f(x, c):

    n = len(c) - 1
    result = 0

    for i, coef in enumerate(c):
        result += coef * (x ** (n - i))

    return result


# =====================================================
# 4) ARALIKTA KÖK VAR MI?
# =====================================================

def has_root(a, b, c):
    return f(a, c) * f(b, c) < 0


# =====================================================
# 5) REGULA FALSI (YER DEĞİŞTİRME)
# =====================================================

def false_position(a, b, c):

    fa = f(a, c)
    fb = f(b, c)

    prev = None
    max_iter = 10000
    tol = 1e-4

    print("\nİterasyonlar:")
    print("iter | a | b | xr | f(xr) | bağıl hata")
    print("-" * 80)

    for i in range(1, max_iter + 1):

        xr = (a * fb - b * fa) / (fb - fa)
        fxr = f(xr, c)

        # =================================================
        # BAĞIL HATA (GÜVENLİ)
        # =================================================
        if prev is None:
            err = 1e9
        else:
            if abs(xr) < 1e-12:
                err = abs(xr - prev)
            else:
                err = abs((xr - prev) / xr)

        print(f"{i:4d} | {a:.6f} | {b:.6f} | {xr:.6f} | {fxr:.6f} | {err:.6f}")

        # =================================================
        # DURMA KRİTERİ (ÖDEV ŞARTI)
        # =================================================
        if err < tol or i >= max_iter:
            return xr

        # aralık güncelle
        if fa * fxr < 0:
            b = xr
            fb = fxr
        else:
            a = xr
            fa = fxr

        prev = xr

    return xr


# =====================================================
# 6) KÖK TEKRAR KONTROL
# =====================================================

def is_new(root, roots):
    return all(abs(root - r) > 0.01 for r in roots)


# =====================================================
# 7) 10 KÖK BULMA ALGORİTMASI
# =====================================================

def find_roots(c):

    roots = []

    limit = 10

    while len(roots) < 10 and limit <= 1000:

        step = max(0.2, limit / 50)

        print(f"\n================ ARALIK: [-{limit}, {limit}] ================")

        x = -limit

        while x < limit and len(roots) < 10:

            a = x
            b = x + step

            # taşmayı önle
            if b > limit:
                b = limit

            # kök kontrolü
            if has_root(a, b, c):

                print("\n--------------------------------------")
                print(f"KÖK ADAYI: [{a:.4f}, {b:.4f}]")
                print("--------------------------------------")

                root = false_position(a, b, c)

                if is_new(root, roots):

                    roots.append(root)

                    print(f"\n✔ YENİ KÖK BULUNDU: {root}")
                    print(f"TOPLAM KÖK: {len(roots)}")

                    # aynı köke tekrar düşmeyi önle
                    x = root + 1
                    continue

            x += step

        limit += 10

    return roots


# =====================================================
# 8) ANA PROGRAM
# =====================================================

coeffs = get_coefficients()

print_polynomial(coeffs)

roots = find_roots(coeffs)

print("\n================ SONUÇ =================\n")

for i, r in enumerate(roots, 1):
    print(f"{i}. kök = {r}")