# Đề bài Console C# - Luyện phỏng vấn Intern/Fresher Backend

> Trình độ: Intern / Fresher. Toàn bộ là bài hay gặp khi phỏng vấn, mức Easy đến Easy-Medium.
> File **không chứa code**. Mỗi bài có đề, ví dụ Input/Output và gợi ý commit message.
> Bài nào có khái niệm hoặc thuật toán cần hiểu thì có mục **Hướng giải**. Bài đơn giản thì không có, bạn tự làm.

## Cách dùng

1. Đọc đề, tự nghĩ 10-15 phút.
2. Bài có mục **Hướng giải** mà bí thì đọc, rồi **đóng file lại và tự code**.
3. Chạy thử các trường hợp đặc biệt: rỗng, 0, số âm, 1 phần tử.
4. Xong bài thì commit lên GitHub với message gợi ý ở cuối mỗi bài.

## Quy ước commit và thư mục

- Một repo duy nhất, ví dụ `csharp-console-practice`.
- Mỗi bài một thư mục, đặt tên theo số thứ tự: `01-SwapTwoNumbers`, `10-TwoSum`, ...
- Commit message viết tiếng Anh, ngắn, bắt đầu bằng động từ: `Add ...`, `Fix ...`, `Refactor ...`.
- Mỗi bài tối thiểu một commit khi giải xong. Nếu sau đó sửa lỗi hoặc tối ưu thì commit thêm một cái riêng (ví dụ `Fix edge case for empty input`).

## Mục lục

| # | Bài | Nhóm |
|---|-----|------|
| 1 | Hoán đổi hai số | Cơ bản |
| 2 | Kiểm tra số chẵn / lẻ | Cơ bản |
| 3 | Tìm số lớn nhất trong 3 số | Cơ bản |
| 4 | Tính tổng từ 1 đến N | Cơ bản |
| 5 | FizzBuzz | Cơ bản |
| 6 | Đảo ngược chuỗi | Chuỗi |
| 7 | Kiểm tra chuỗi đối xứng (Palindrome) | Chuỗi |
| 8 | Đếm số lần xuất hiện của ký tự | Chuỗi |
| 9 | Kiểm tra Anagram | Chuỗi |
| 10 | Ký tự đầu tiên không lặp | Chuỗi |
| 11 | Tìm số lớn nhất / nhỏ nhất trong mảng | Mảng |
| 12 | Loại bỏ phần tử trùng | Mảng |
| 13 | Tìm phần tử xuất hiện nhiều nhất | Mảng |
| 14 | Two Sum | Mảng |
| 15 | Gộp hai mảng đã sắp xếp | Mảng |
| 16 | Kiểm tra số nguyên tố | Số học |
| 17 | In các số nguyên tố nhỏ hơn hoặc bằng N | Số học |
| 18 | Dãy Fibonacci | Số học |
| 19 | Giai thừa | Số học |
| 20 | UCLN và BCNN | Số học |
| 21 | Đảo ngược số và tổng chữ số | Số học |
| 22 | Thống kê danh sách sinh viên | LINQ |
| 23 | Thiết kế class Shape | OOP |
| 24 | Quản lý tài khoản ngân hàng | OOP |

---

# PHẦN 1: CƠ BẢN

## Bài 1. Hoán đổi hai số

**Đề bài:** Nhập hai số nguyên a và b. Hoán đổi giá trị của chúng rồi in ra.

| Input | Output |
|-------|--------|
| a = 5, b = 9 | a = 9, b = 5 |
| a = -1, b = 0 | a = 0, b = -1 |

**Commit message:** `Add swap two numbers solution`

---

## Bài 2. Kiểm tra số chẵn / lẻ

**Đề bài:** Nhập một số nguyên, in ra "Chẵn" hoặc "Lẻ".

| Input | Output |
|-------|--------|
| 4 | Chẵn |
| 7 | Lẻ |
| 0 | Chẵn |
| -3 | Lẻ |

**Commit message:** `Add check even or odd solution`

---

## Bài 3. Tìm số lớn nhất trong 3 số

**Đề bài:** Nhập ba số nguyên, in ra số lớn nhất. Không dùng hàm Max có sẵn.

| Input | Output |
|-------|--------|
| 3, 8, 5 | 8 |
| -1, -5, -2 | -1 |
| 4, 4, 2 | 4 |

**Commit message:** `Add find max of three numbers solution`

---

## Bài 4. Tính tổng từ 1 đến N

**Đề bài:** Nhập số nguyên dương N, tính tổng 1 + 2 + ... + N.

| Input | Output |
|-------|--------|
| 5 | 15 |
| 10 | 55 |
| 1 | 1 |

**Commit message:** `Add sum from 1 to N solution`

---

## Bài 5. FizzBuzz

**Đề bài:** Nhập N. In các số từ 1 đến N, nhưng số chia hết cho 3 thì in `Fizz`, chia hết cho 5 thì in `Buzz`, chia hết cho cả 3 và 5 thì in `FizzBuzz`.

| Input | Output |
|-------|--------|
| 5 | 1, 2, Fizz, 4, Buzz |
| 15 | 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz |

**Commit message:** `Add FizzBuzz solution`

---

# PHẦN 2: CHUỖI

## Bài 6. Đảo ngược chuỗi

**Đề bài:** Nhập một chuỗi, in ra chuỗi đảo ngược. Không dùng hàm đảo có sẵn.

| Input | Output |
|-------|--------|
| `hello` | `olleh` |
| `Xin chao` | `oahc niX` |
| (rỗng) | (rỗng) |

**Commit message:** `Add reverse string solution`

---

## Bài 7. Kiểm tra chuỗi đối xứng (Palindrome)

**Đề bài:** Kiểm tra chuỗi đọc xuôi và ngược có giống nhau không. Bỏ qua phân biệt hoa/thường.

| Input | Output |
|-------|--------|
| `level` | Có |
| `Madam` | Có |
| `hello` | Không |
| `a` | Có |

**Commit message:** `Add palindrome check solution`

---

## Bài 8. Đếm số lần xuất hiện của ký tự

**Đề bài:** Nhập chuỗi, đếm mỗi ký tự xuất hiện bao nhiêu lần rồi in ra.

| Input | Output |
|-------|--------|
| `banana` | b: 1, a: 3, n: 2 |
| `hello` | h: 1, e: 1, l: 2, o: 1 |

### Hướng giải

Bài này giới thiệu **Dictionary**, một cấu trúc rất hay dùng, bạn nên hiểu rõ.

- **Dictionary là gì?** Là một "cuốn sổ tra cứu" gồm các cặp **khóa - giá trị**. Giống danh bạ điện thoại: tên là khóa, số điện thoại là giá trị. Mỗi khóa chỉ xuất hiện một lần.
- **Áp dụng:** khóa là ký tự, giá trị là số lần ký tự đó đã xuất hiện.
- **Cách làm:** duyệt từng ký tự trong chuỗi.
  - Nếu ký tự **đã có** trong Dictionary thì tăng giá trị của nó lên 1.
  - Nếu **chưa có** thì thêm vào với giá trị 1.
- Ví dụ `banana`: gặp b (thêm b=1), a (thêm a=1), n (thêm n=1), a (a thành 2), n (n thành 2), a (a thành 3). Kết quả b:1, a:3, n:2.
- Cách đếm tần suất này là nền tảng cho các bài 9, 10, 13.

**Commit message:** `Add count character frequency using Dictionary`

---

## Bài 9. Kiểm tra Anagram

**Đề bài:** Hai chuỗi là Anagram nếu chứa cùng các ký tự với cùng số lần, chỉ khác thứ tự. Kiểm tra hai chuỗi có phải Anagram không.

| Input | Output |
|-------|--------|
| `listen`, `silent` | Có |
| `abc`, `cab` | Có |
| `hello`, `world` | Không |
| `aab`, `abb` | Không |

### Hướng giải

- **Anagram là gì?** Là hai từ tạo thành từ cùng một bộ chữ cái, chỉ xếp lại thứ tự. `listen` và `silent` đều gồm l, i, s, t, e, n.
- **Bước 0:** nếu độ dài hai chuỗi khác nhau thì chắc chắn "Không", dừng luôn.
- **Cách 1 (dễ nghĩ nhất):** sắp xếp các ký tự của cả hai chuỗi theo thứ tự chữ cái. Nếu hai chuỗi sau khi sắp xếp giống hệt nhau thì là Anagram.
  - `listen` sắp xếp thành `eilnst`, `silent` sắp xếp thành `eilnst`. Giống nhau, vậy là Anagram.
- **Cách 2 (nhanh hơn, nên nhắc khi phỏng vấn):** đếm tần suất ký tự của chuỗi thứ nhất bằng Dictionary (như bài 8). Sau đó duyệt chuỗi thứ hai và **trừ** đi từng ký tự. Nếu gặp ký tự không có hoặc số lần bị âm thì "Không". Duyệt hết mà không sao thì "Có".

**Commit message:** `Add anagram check solution`

---

## Bài 10. Ký tự đầu tiên không lặp

**Đề bài:** Tìm ký tự đầu tiên (từ trái sang) chỉ xuất hiện đúng một lần. Nếu không có thì thông báo không có.

| Input | Output |
|-------|--------|
| `swiss` | `w` |
| `aabbcd` | `c` |
| `aabb` | Không có |

### Hướng giải

Bài này làm **hai lượt duyệt**:

1. **Lượt 1:** đếm tần suất từng ký tự bằng Dictionary (như bài 8).
2. **Lượt 2:** duyệt lại chuỗi **theo thứ tự ban đầu**. Ký tự nào có tần suất bằng 1 thì dừng và trả về luôn.

Lưu ý: ở lượt 2 phải duyệt theo chuỗi gốc, không duyệt Dictionary, vì chỉ có chuỗi gốc mới giữ đúng thứ tự "đầu tiên".

Ví dụ `swiss`: tần suất s=3, w=1, i=1. Duyệt lại: s (3, bỏ qua), w (1, chọn). Kết quả `w`.

**Commit message:** `Add first non-repeating character solution`

---

# PHẦN 3: MẢNG

## Bài 11. Tìm số lớn nhất / nhỏ nhất trong mảng

**Đề bài:** Cho mảng số nguyên, tìm số lớn nhất và nhỏ nhất. Không dùng hàm Max, Min có sẵn.

| Input | Output |
|-------|--------|
| `[3, 7, 1, 9, 4]` | Lớn nhất 9, nhỏ nhất 1 |
| `[-5, -2, -9]` | Lớn nhất -2, nhỏ nhất -9 |
| `[8]` | Lớn nhất 8, nhỏ nhất 8 |

**Commit message:** `Add find min and max in array solution`

---

## Bài 12. Loại bỏ phần tử trùng

**Đề bài:** Cho mảng số nguyên, trả về mảng mới không còn phần tử trùng, giữ nguyên thứ tự xuất hiện lần đầu.

| Input | Output |
|-------|--------|
| `[1, 2, 2, 3, 1, 4]` | `[1, 2, 3, 4]` |
| `[5, 5, 5]` | `[5]` |
| `[]` | `[]` |

### Hướng giải

- **HashSet là gì?** Là một "cái túi" chỉ chứa các giá trị **không trùng nhau**, và kiểm tra "có trong túi chưa" rất nhanh.
- **Cách làm:** duyệt từng số trong mảng. Nếu số đó **chưa có** trong HashSet thì thêm vào HashSet và thêm vào kết quả. Nếu **có rồi** thì bỏ qua.
- Ví dụ `[1, 2, 2, 3, 1, 4]`: 1 (mới, giữ), 2 (mới, giữ), 2 (trùng, bỏ), 3 (mới, giữ), 1 (trùng, bỏ), 4 (mới, giữ). Kết quả `[1, 2, 3, 4]`.

**Commit message:** `Add remove duplicates using HashSet`

---

## Bài 13. Tìm phần tử xuất hiện nhiều nhất

**Đề bài:** Cho mảng số nguyên, tìm số xuất hiện nhiều lần nhất và số lần đó.

| Input | Output |
|-------|--------|
| `[1, 3, 3, 2, 3, 1]` | Số 3, xuất hiện 3 lần |
| `[4, 4, 5, 5, 4]` | Số 4, xuất hiện 3 lần |

### Hướng giải

Giống bài 8 nhưng đếm số thay vì ký tự: dùng Dictionary, khóa là số, giá trị là số lần xuất hiện. Đếm xong, duyệt Dictionary để tìm giá trị lớn nhất.

Nếu có nhiều số cùng xuất hiện nhiều nhất, hãy hỏi lại người phỏng vấn muốn in một hay tất cả. Hỏi lại yêu cầu là điểm cộng.

**Commit message:** `Add most frequent element solution`

---

## Bài 14. Two Sum

**Đề bài:** Cho mảng số nguyên và một số `target`. Tìm hai phần tử có tổng bằng `target`, in ra vị trí (chỉ số) của chúng. Giả sử luôn có đúng một đáp án và không dùng một phần tử hai lần.

| Input | Output |
|-------|--------|
| mảng `[2, 7, 11, 15]`, target = 9 | Vị trí 0 và 1 (2 + 7 = 9) |
| mảng `[3, 2, 4]`, target = 6 | Vị trí 1 và 2 (2 + 4 = 6) |
| mảng `[3, 3]`, target = 6 | Vị trí 0 và 1 |

### Hướng giải

**Cách 1 (dễ nghĩ nhưng chậm):** dùng hai vòng lặp lồng nhau, thử mọi cặp số. Đúng nhưng chậm khi mảng lớn, vì phải thử rất nhiều cặp.

**Cách 2 (nên trình bày khi phỏng vấn):** dùng Dictionary với khóa là giá trị số, giá trị là vị trí của số đó.

Ý tưởng: với mỗi số đang xét, tính "số cần tìm" = target trừ số hiện tại. Nếu số cần tìm **đã từng gặp** thì xong.

Các bước:
1. Duyệt từng số trong mảng.
2. Tính số cần tìm = target trừ số hiện tại.
3. Nếu số cần tìm đã có trong Dictionary thì trả về vị trí của nó cùng vị trí hiện tại.
4. Nếu chưa có thì lưu số hiện tại và vị trí của nó vào Dictionary, rồi đi tiếp.

Ví dụ `[2, 7, 11, 15]`, target 9: gặp 2, cần 7, chưa có nên lưu 2. Gặp 7, cần 2, đã có, trả về vị trí 0 và 1.

Điểm mạnh: chỉ duyệt mảng một lần.

**Commit message:** `Add Two Sum solution using Dictionary`

---

## Bài 15. Gộp hai mảng đã sắp xếp

**Đề bài:** Cho hai mảng số nguyên đã sắp xếp tăng dần. Gộp thành một mảng sắp xếp tăng dần, không gộp rồi sắp xếp lại.

| Input | Output |
|-------|--------|
| `[1, 3, 5]` và `[2, 4, 6]` | `[1, 2, 3, 4, 5, 6]` |
| `[1, 2]` và `[3, 4, 5]` | `[1, 2, 3, 4, 5]` |
| `[]` và `[1, 2]` | `[1, 2]` |

### Hướng giải

Kỹ thuật **hai con trỏ**: tưởng tượng hai chồng bài đã xếp sẵn, mỗi lần lấy lá nhỏ hơn ở trên cùng hai chồng.

1. Đặt một con trỏ ở đầu mỗi mảng.
2. So sánh hai phần tử đang trỏ tới. Lấy phần tử **nhỏ hơn** đưa vào kết quả, rồi dịch con trỏ của mảng đó lên một bước.
3. Lặp lại đến khi một mảng hết phần tử.
4. Mảng còn lại vẫn đã sắp xếp sẵn, nối thẳng phần còn lại vào cuối kết quả.

Ví dụ `[1, 3, 5]` và `[2, 4, 6]`: so 1 và 2 lấy 1; so 3 và 2 lấy 2; so 3 và 4 lấy 3; so 5 và 4 lấy 4; so 5 và 6 lấy 5; mảng đầu hết, nối nốt 6.

**Commit message:** `Add merge two sorted arrays solution`

---

# PHẦN 4: SỐ HỌC

## Bài 16. Kiểm tra số nguyên tố

**Đề bài:** Nhập số nguyên N, kiểm tra N có phải số nguyên tố không.

| Input | Output |
|-------|--------|
| 7 | Là số nguyên tố |
| 10 | Không phải |
| 2 | Là số nguyên tố |
| 1 | Không phải |
| 0, -5 | Không phải |

### Hướng giải

**Số nguyên tố là gì?**
- Là số tự nhiên **lớn hơn 1** và **chỉ chia hết cho 1 và chính nó** (đúng hai ước).
- 7 chỉ chia hết cho 1 và 7, nên là số nguyên tố. 10 chia hết cho 1, 2, 5, 10, nên không phải.
- Những điểm hay bị hỏi bẫy:
  - **Số 1 không phải số nguyên tố** (chỉ có một ước).
  - **Số 2 là số nguyên tố**, và là số nguyên tố chẵn duy nhất.
  - Số 0 và số âm không phải số nguyên tố.

**Cách kiểm tra:**

*Cách 1: thử chia từ 2 đến N-1 (dễ hiểu nhất)*
1. Nếu N nhỏ hơn 2 thì kết luận không phải.
2. Thử chia N cho lần lượt 2, 3, 4, ..., N-1.
3. Nếu có số nào chia hết N (số dư bằng 0) thì N không phải số nguyên tố, dừng ngay.
4. Thử hết mà không số nào chia hết thì N là số nguyên tố.

*Cách 2: chỉ thử đến căn bậc hai của N (nên dùng)*
- Lý do: ước của N luôn đi thành cặp. Nếu có một ước lớn hơn căn N thì chắc chắn có ước đi cặp với nó nhỏ hơn căn N. Ví dụ N = 36, căn là 6. Ước 9 đi cặp với ước 4 (9 x 4 = 36), mà 4 nhỏ hơn 6. Vậy chỉ cần tìm ước từ 2 đến 6 là đủ.
- Ví dụ N = 29: căn xấp xỉ 5.38, chỉ cần thử 2, 3, 4, 5. Không số nào chia hết, vậy 29 là số nguyên tố. Chỉ thử 4 lần thay vì 27 lần.
- Mẹo trong C#: thay vì tính căn, dùng điều kiện vòng lặp "i nhân i nhỏ hơn hoặc bằng N".

*Cách 3: tối ưu thêm*
- Nếu N chia hết cho 2 và N khác 2 thì loại luôn.
- Sau đó chỉ thử các số lẻ: 3, 5, 7, ...

**Commit message:** `Add prime number check solution`

---

## Bài 17. In các số nguyên tố nhỏ hơn hoặc bằng N

**Đề bài:** Nhập N, in tất cả số nguyên tố từ 2 đến N.

| Input | Output |
|-------|--------|
| N = 10 | 2, 3, 5, 7 |
| N = 20 | 2, 3, 5, 7, 11, 13, 17, 19 |
| N = 1 | (không có số nào) |

### Hướng giải

**Cách đơn giản (đủ cho intern):** với mỗi số từ 2 đến N, dùng lại cách kiểm tra ở bài 16. Số nào là số nguyên tố thì in.

**Cách nâng cao: Sàng Eratosthenes (nên biết tên, là điểm cộng)**

Ý tưởng: thay vì kiểm tra từng số, ta **gạch bỏ các bội của số nguyên tố**. Số nào còn lại không bị gạch là số nguyên tố.

1. Viết danh sách các số từ 2 đến N, ban đầu coi tất cả là số nguyên tố.
2. Lấy số chưa bị gạch nhỏ nhất (bắt đầu là 2), gạch bỏ tất cả bội của nó (4, 6, 8, ...).
3. Chuyển sang số kế tiếp chưa bị gạch (3), gạch bỏ các bội của nó (6, 9, 12, ...).
4. Lặp lại đến khi bình phương của số đang xét vượt quá N.
5. Các số còn lại là số nguyên tố.

Ví dụ N = 20: gạch bội của 2 (4, 6, 8, 10, 12, 14, 16, 18, 20), gạch bội của 3 (9, 15). Số 5 có bình phương 25 lớn hơn 20 nên dừng. Còn lại 2, 3, 5, 7, 11, 13, 17, 19.

**Commit message:** `Add list primes up to N solution`

---

## Bài 18. Dãy Fibonacci

**Đề bài:** Nhập N, in N số đầu tiên của dãy Fibonacci.

| Input | Output |
|-------|--------|
| N = 1 | 0 |
| N = 5 | 0, 1, 1, 2, 3 |
| N = 10 | 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 |

### Hướng giải

**Dãy Fibonacci là gì?** Hai số đầu là 0 và 1. Mỗi số tiếp theo bằng **tổng hai số đứng ngay trước nó**: 0 + 1 = 1, 1 + 1 = 2, 1 + 2 = 3, 2 + 3 = 5, 3 + 5 = 8, ...

**Cách vòng lặp (nên dùng):**
1. Dùng hai biến lưu hai số gần nhất, ban đầu là 0 và 1.
2. Mỗi vòng lặp: in số hiện tại, tính số tiếp theo bằng tổng hai biến, rồi "dịch" hai biến lên một vị trí.
3. Xử lý riêng trường hợp N bằng 0 hoặc 1.

**Cách đệ quy (hay bị hỏi thêm):** Fib(n) bằng Fib(n-1) cộng Fib(n-2), điều kiện dừng là n bằng 0 hoặc 1. Nhưng đệ quy thuần rất chậm vì tính lặp lại nhiều lần cùng một giá trị. Nhắc được điểm này khi phỏng vấn là điểm cộng.

**Commit message:** `Add Fibonacci sequence solution`

---

## Bài 19. Giai thừa

**Đề bài:** Nhập số nguyên không âm N, tính N giai thừa (N!).

| Input | Output |
|-------|--------|
| 5 | 120 |
| 3 | 6 |
| 0 | 1 |

### Hướng giải

- **Giai thừa là gì?** N! là tích của tất cả số nguyên từ 1 đến N. Ví dụ 5! = 5 x 4 x 3 x 2 x 1 = 120. **Quy ước 0! = 1.**
- **Cách làm:** dùng vòng lặp, biến kết quả bắt đầu bằng 1, nhân dần với 2, 3, ..., N.
- **Bẫy cần biết:** giai thừa tăng rất nhanh. Với kiểu `int`, từ khoảng N = 13 đã bị tràn số; với `long`, từ khoảng N = 21 cũng tràn. Có thể nhắc đến `long` hoặc `BigInteger`.
- **Số âm:** giai thừa không định nghĩa cho số âm, nên báo lỗi.

**Commit message:** `Add factorial solution`

---

## Bài 20. UCLN và BCNN

**Đề bài:** Nhập hai số nguyên dương a và b. Tìm ước chung lớn nhất (UCLN) và bội chung nhỏ nhất (BCNN).

| Input | Output |
|-------|--------|
| 12, 18 | UCLN = 6, BCNN = 36 |
| 7, 5 | UCLN = 1, BCNN = 35 |
| 10, 10 | UCLN = 10, BCNN = 10 |

### Hướng giải

**Khái niệm:**
- **UCLN** là số lớn nhất mà cả a và b đều chia hết. Với 12 và 18: ước của 12 là 1, 2, 3, 4, 6, 12; ước của 18 là 1, 2, 3, 6, 9, 18. Ước chung lớn nhất là 6.
- **BCNN** là số nhỏ nhất mà cả a và b đều là ước của nó.

**Tìm UCLN bằng thuật toán Euclid (cách chuẩn):**
1. Chia a cho b, lấy số dư.
2. Gán a bằng b cũ, gán b bằng số dư.
3. Lặp lại đến khi b bằng 0. Lúc đó a chính là UCLN.

Ví dụ 12 và 18: 18 chia 12 dư 6. Rồi 12 chia 6 dư 0. Dừng, UCLN = 6.

**Tính BCNN từ UCLN:** BCNN bằng (a nhân b) chia cho UCLN. Với 12 và 18: 12 x 18 / 6 = 36.

**Commit message:** `Add GCD and LCM solution using Euclid algorithm`

---

## Bài 21. Đảo ngược số và tổng chữ số

**Đề bài:** Nhập số nguyên dương N. (a) In số đảo ngược của N. (b) Tính tổng các chữ số của N.

| Input | Đảo ngược | Tổng chữ số |
|-------|-----------|-------------|
| 1234 | 4321 | 10 |
| 905 | 509 | 14 |
| 7 | 7 | 7 |

### Hướng giải

Mẹo cốt lõi, cần nhớ:
- **Chia lấy dư cho 10** cho ra **chữ số cuối cùng**.
- **Chia nguyên cho 10** sẽ **bỏ chữ số cuối cùng**.

Với 1234:
- 1234 chia 10 dư 4 (chữ số cuối), còn lại 123.
- 123 chia 10 dư 3, còn lại 12.
- 12 chia 10 dư 2, còn lại 1.
- 1 chia 10 dư 1, còn lại 0. Dừng khi số còn lại bằng 0.

**Tổng chữ số:** cộng dồn các chữ số lấy ra được: 4 + 3 + 2 + 1 = 10.

**Đảo số:** mỗi lần lấy ra một chữ số, lấy kết quả hiện tại nhân 10 rồi cộng chữ số đó. Với 1234: 0 thành 4, thành 43, thành 432, thành 4321.

**Commit message:** `Add reverse number and sum of digits solution`

---

# PHẦN 5: LINQ VÀ OOP

## Bài 22. Thống kê danh sách sinh viên (LINQ)

**Đề bài:** Có danh sách sinh viên gồm Tên, Tuổi, Điểm:

| Tên | Tuổi | Điểm |
|-----|------|------|
| An | 20 | 8.5 |
| Bình | 21 | 6.0 |
| Chi | 20 | 9.0 |
| Dũng | 22 | 5.5 |
| Em | 21 | 7.5 |

Dùng LINQ để:
1. Lấy sinh viên có điểm từ 7.0 trở lên.
2. Sắp xếp theo điểm giảm dần.
3. Tính điểm trung bình.
4. Tìm sinh viên có điểm cao nhất.
5. Nhóm sinh viên theo tuổi và đếm số lượng mỗi nhóm.
6. Kiểm tra có sinh viên nào dưới 6.0 điểm không.

| Yêu cầu | Kết quả |
|---------|---------|
| 1 | An, Chi, Em |
| 2 | Chi (9.0), An (8.5), Em (7.5), Bình (6.0), Dũng (5.5) |
| 3 | 7.3 |
| 4 | Chi |
| 5 | Tuổi 20: 2 người, tuổi 21: 2 người, tuổi 22: 1 người |
| 6 | Có (Dũng) |

**Từ khóa LINQ cần tra:** `Where` (lọc), `OrderByDescending` (sắp xếp giảm), `Average` (trung bình), `Max`, `GroupBy` (nhóm), `Any` (có hay không), `Select` (chọn / biến đổi).

**Commit message:** `Add student statistics using LINQ`

---

## Bài 23. Thiết kế class Shape (OOP)

**Đề bài:** Thiết kế các hình: Hình tròn, Hình chữ nhật, Hình vuông. Mỗi hình tính được **diện tích** và **chu vi**. Tạo một danh sách chứa nhiều hình khác nhau, rồi in diện tích và chu vi từng hình.

| Hình | Thông số | Diện tích | Chu vi |
|------|----------|-----------|--------|
| Chữ nhật | dài 4, rộng 3 | 12 | 14 |
| Tròn | bán kính 2 | khoảng 12.57 | khoảng 12.57 |
| Vuông | cạnh 5 | 25 | 20 |

### Hướng giải

- Tạo một class cha trừu tượng `Shape` (hoặc interface) có hai phương thức: tính diện tích và tính chu vi.
- Mỗi hình kế thừa `Shape` và **tự cài đặt** cách tính của riêng nó.
- Tạo một danh sách kiểu `Shape`, thêm các hình khác nhau vào, rồi duyệt và gọi phương thức. Mỗi hình sẽ tự tính theo cách của mình. Đây là **đa hình (polymorphism)**.
- Công thức hình tròn: diện tích = pi x bán kính bình phương; chu vi = 2 x pi x bán kính.
- Câu hỏi thường gặp kèm theo: abstract class khác interface chỗ nào, khi nào dùng cái nào.

**Commit message:** `Add Shape hierarchy demonstrating polymorphism`

---

## Bài 24. Quản lý tài khoản ngân hàng (OOP)

**Đề bài:** Tạo class `BankAccount` có số tài khoản, tên chủ tài khoản, số dư. Có các chức năng:
- Nạp tiền (số tiền phải lớn hơn 0).
- Rút tiền (không được rút quá số dư, số tiền phải lớn hơn 0).
- Xem số dư.

| Thao tác | Kết quả |
|----------|---------|
| Tạo tài khoản, số dư ban đầu 1000 | Số dư 1000 |
| Nạp 500 | Số dư 1500 |
| Rút 200 | Số dư 1300 |
| Rút 5000 | Báo lỗi "Số dư không đủ", số dư vẫn 1300 |
| Nạp -100 | Báo lỗi "Số tiền không hợp lệ" |

### Hướng giải

- **Đóng gói (encapsulation):** để số dư ở chế độ `private`, bên ngoài không sửa trực tiếp mà chỉ thay đổi qua phương thức nạp/rút.
- Mỗi phương thức phải **kiểm tra điều kiện trước**, hợp lệ mới thay đổi số dư.
- Cách báo lỗi: ném ngoại lệ (exception) hoặc trả về kết quả thành công/thất bại. Hãy chọn một cách và giải thích được vì sao.
- Mở rộng nếu còn thời gian: class con `SavingsAccount` có lãi suất, hoặc lưu lịch sử giao dịch vào một danh sách.

**Commit message:** `Add BankAccount class with deposit and withdraw`

---

# Checklist trước khi commit

- [ ] Đã thử input rỗng, 0, số âm, 1 phần tử chưa?
- [ ] Tên biến, tên hàm có rõ nghĩa không?
- [ ] Đã tách logic ra hàm riêng thay vì viết hết trong Main chưa?
- [ ] Giải thích được cách làm bằng lời của mình chưa?
- [ ] Đã loại bỏ thư mục `bin` và `obj` khỏi commit chưa (dùng `.gitignore` template VisualStudio)?

# Lịch luyện gợi ý (2 tuần)

| Ngày | Bài |
|------|-----|
| 1 | 1, 2, 3, 4, 5 |
| 2-3 | 6, 7, 8, 9 |
| 4 | 10, 11, 12 |
| 5-6 | 13, 14, 15 |
| 7 | Làm lại không nhìn hướng giải: 9, 12, 14 |
| 8-9 | 16, 17, 18 |
| 10 | 19, 20, 21 |
| 11-12 | 22, 23, 24 |
| 13-14 | Tự bấm giờ làm ngẫu nhiên 3 bài, mỗi bài 15 phút, vừa làm vừa nói to suy nghĩ |
