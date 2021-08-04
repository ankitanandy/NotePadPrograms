using System;
public SortingAlgorithms{
	public void Main(string[] args)
	{
		int[] inputArray = {4,6,8,9,10};
		
		BubbleSort(inputArray);
	}
	
	public void MergeSort(int[] arr)
	{
		int n= arr.Length;
		
		int l=0;int h = n-1;
			int m= (l+h)/2;
			int k =m-1<0?0;m-1;
			
			
	}
	
	public void Merge()
	{
	}
	
	public void sort(int arr[], int l, int r) 
    { 
        if (l < r) 
        { 
            // Find the middle point 
            int m = (l+r)/2; 
  
            // Sort first and second halves 
            sort(arr, l, m); 
            sort(arr , m+1, r); 
  
            // Merge the sorted halves 
            merge(arr, l, m, r); 
        } 
    } 
	
	
	
	
	public void BubbleSort(int[] arr)
	{
		for(int i=0;i<arr.Length; i++)
		{
			for(int j=1;j<arr.Length;j++)
			{
				if(arr[i]>[arr[j])
				{
					temp = arr[i];
					arr[i]=arr[j];
					arr[j]=temp;					
				}
			}
		}
		
		for(int i=0;i<arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}

}