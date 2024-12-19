string? input = Console.ReadLine();

int[] pointer = [0];
int loc = 0;

if(input == string.Empty || input == null){
    Console.WriteLine("입력한 정보가 없습니다");
    Environment.Exit(0);
}

foreach (var x in input) {
    switch(x){
        case '+':
            pointer[loc] += 1;
            break;
        case '>':
            loc += 1;
            // 값이 없는 경우엔 array 추가하기
            break;
        case '.':
            Console.WriteLine(Convert.ToChar(pointer[loc]));
            break;
    }
}