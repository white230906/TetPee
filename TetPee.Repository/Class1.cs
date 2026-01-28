namespace TetPee.Repository;

public class Class1
{
    // ORM: Object-Relational Mapping
    
    //Code first and database first
    
    //Thông thường để mà ở trên code mà để có thể làm việc với db
    //  thì mình cần ánh xạ  (mapping) các table từ db lên code
    //  để dễ quản lí và làm việc
    
    // Db First:
    //  - Làm việc với db có sẵn. setup một db
    //  - Vô tạo Create Table, Create Db, setup Field, Set Relationships
    // - Sau đó ở trên code sử dụng các Driver hoặc Orm để kết nói xuống Database
    //  - Ở trên code sẽ tạo những class tương ứng với các table trong database.
    // - Thằng này sử dụng khi nào: khi mình có database có sẵn và đã sử dụng trong rất nhiều năm rồi, những dự án maintain - code first
    
    
    // Code first
    // - Mình sẽ không setup Database thủ công bằng các query
    // - Không vô tạo Create Table, Create Db, setup Field, Set Relationships
    // - Mình design bằng những class trên code luôn, trên code setup các Entity, các Field, các relationships
    // - Sau đó ánh xạ từ class xuống các table trong batabase
    // Vậy làm sao để ánh xạ được, từ các class trên code xuống Database: ORM: Object-Relational Mapping
    // Thằng này sử dụng khi: Dự án mới, hiện đại, nhiều công cụ hổ trợ
    
    //Tuyệt đỉnh ORM của .NET: Entity Framework. Không biết sử dụng và thành thục thằng này thì mất 90% sức mạnh .NEt
    
    
}