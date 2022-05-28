public class Search{
    public static void Main(){
        // 昇順にソートされた配列
        var sortedArray = new int[] {1, 2, 3, 5, 12, 7890, 12345};
        // 探索対象の番号
        var targetNumber = 7890;
        // 探索実行
        var targetIndex = new Search().SearchIndex(sortedArray, targetNumber);
        // 結果出力
        System.Console.WriteLine(targetIndex);
    }

    private int SearchIndex(int[] sortedArray, int targetNumber){

        // ここから記述
            int length = sortedArray.Length; // 要素数を取得
            int index = length/2; // 要素数の半分を初期値に設定
            bool check = false;
            
            // 配列内に指定の数値があるかチェック
            for (int i = 0; i < length; i++)
            {
                if (targetNumber == sortedArray[i]) check = true; // ある場合はcheckをtrueに
            }
            
            // 配列の中間値と指定の数値が合うまでループ
            while (sortedArray[index] != targetNumber && check)
            {
                //　indexが1の時半分に出来ないので逃がす
                if(index == 1)
                {
                    index--;
                    break;
                }
                // 中間値が小さければ残りの要素数の半分を足す
                else if (sortedArray[index] <= targetNumber)
                {
                    index += (length - index) / 2;
                }
                // 中間値が大きければ残りの要素数の半分を引く
                else
                {
                    index -= index/ 2;
                }
            }
            // 配列内に指定の数値があった場合indexを返す
            if(check) return index;

        // ここまで記述

        // 探索対象がない場合、-1を返す
        return -1;
    }
}
