

using System.Collections.Generic;

public class HashMap {

    private List<int>[] hashMap;

    public HashMap() {
        hashMap = new[] { new List<int>() };
    }

    public static int computeHash(int valueToHash, int hashMapLength) {
        if(hashMapLength == 0) {
            return -1;
        }

        return valueToHash % hashMapLength;
    }

    public void put(int inNewValue) {
        int hash = computeHash(inNewValue, hashMap.Length);

        if(hashMap[hash].Count == 0) {
            hashMap[hash].Add(inNewValue);
        }
        else {
            hashMap[hash].Add(inNewValue);

            //int i;
            //for(i = 0; hashMap[hash].Count > 0; i++) {
            //}
        }
    }

    public void get(int inNewValue) { }

}
