namespace Interface.Model
{
    public interface ICourse
    {
        int Credit { get; set; }
        string Name { get; set; }

        void AddStudent(Student st);
    }
}