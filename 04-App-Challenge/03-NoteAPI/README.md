# 60-Minute App Challenge: Note-Taking API

**Difficulty:** Intermediate-Advanced | **Time:** 50-60 minutes | **Copilot Focus:** Full-Featured API with Search & Filtering

---

## 🎯 Challenge Overview

Build a **full-featured Note-Taking API** with search, tagging, and advanced filtering in 50-60 minutes.

### **Features:**
- ✅ CRUD operations on notes
- ✅ Full-text search across note titles and content
- ✅ Tag-based organization
- ✅ Sort and filter capabilities
- ✅ Advanced query parameters
- ✅ Comprehensive validation
- ✅ Unit + integration tests
- ✅ Entity relationships (notes → tags)

---

## 📋 Requirements

### **Models:**

**Note:**
```json
{
  "id": 1,
  "title": "Learning Copilot",
  "content": "Today I learned about AI-assisted coding...",
  "tags": ["learning", "ai", "copilot"],
  "createdDate": "2024-01-29T10:00:00Z",
  "modifiedDate": "2024-01-29T14:30:00Z",
  "isFavorite": true,
  "priority": "High"
}
```

**Tag:**
```json
{
  "id": 1,
  "name": "learning",
  "color": "#FF5733",
  "noteCount": 5
}
```

### **Endpoints:**

| Method | Route | Description |
|--------|-------|-------------|
| GET | `/api/notes` | Get all notes (paginated) |
| GET | `/api/notes/search` | Full-text search (query param) |
| GET | `/api/notes/tag/{tag}` | Get notes by tag |
| GET | `/api/notes/{id}` | Get single note |
| POST | `/api/notes` | Create note |
| PUT | `/api/notes/{id}` | Update note |
| DELETE | `/api/notes/{id}` | Delete note |
| GET | `/api/tags` | Get all tags |
| POST | `/api/tags` | Create tag |

### **Query Parameters:**
- `page=1&pageSize=10` — Pagination
- `search=copilot` — Full-text search
- `tags=learning,ai` — Filter by multiple tags
- `sortBy=created&sortOrder=desc` — Sorting
- `favorite=true` — Filter by favorite
- `priority=High` — Filter by priority

---

## 🤖 Copilot Prompting Strategy

### **Phase 1: Architecture Planning (8 minutes)**
```
I'm building a feature-rich note-taking API in 50 minutes.
Design the architecture including:
1. Models (Note, Tag) with relationships
2. Service layer with search/filter logic
3. Repository pattern
4. Query/filter parameter handling
5. Pagination strategy
6. Validation approach
7. Error handling strategy
```

### **Phase 2: Database/Repository Setup (8 minutes)**
```
Create:
- Note and Tag models with Entity Framework relationships
- InMemoryRepository with query capabilities
- Filter/search logic
- Pagination support

Use LINQ for filtering and searching.
Include async/await.
```

### **Phase 3: API Implementation (20 minutes)**
```
Generate the NotesController with:
- All CRUD endpoints
- Search endpoint with full-text search
- Tag filtering
- Sorting capabilities
- Pagination
- Proper HTTP status codes
- Comprehensive error handling
- Input validation
```

### **Phase 4: Search/Filter Logic (8 minutes)**
```
Implement advanced search:
- Search across title and content
- Case-insensitive matching
- Multiple tag filtering (AND logic)
- Date range filtering (optional)
- Sorting by multiple fields
- Efficient LINQ queries
```

### **Phase 5: Testing & Documentation (16 minutes)**
```
/tests
Generate comprehensive tests for:
- CRUD operations
- Search functionality
- Tag filtering
- Pagination
- Error scenarios
- Performance (search speed)

/doc
Add XML documentation to all public methods.
```

---

## 🚀 Quick Start

1. **Create project:**
   ```bash
   dotnet new webapi -n NotesAPI
   cd NotesAPI
   ```

2. **Create structure:**
   ```
   Models/
   ├── Note.cs
   ├── Tag.cs
   ├── CreateNoteRequest.cs
   ├── NoteResponse.cs
   Services/
   ├── INoteService.cs
   ├── NoteService.cs
   Repositories/
   ├── IRepository.cs
   ├── InMemoryRepository.cs
   Controllers/
   ├── NotesController.cs
   ├── TagsController.cs
   ```

3. **Use Copilot** for each component
4. **Test endpoints:**
   ```bash
   # Search notes
   curl "http://localhost:5000/api/notes/search?q=copilot"

   # Get notes by tag
   curl "http://localhost:5000/api/notes/tag/learning"

   # Paginated results
   curl "http://localhost:5000/api/notes?page=1&pageSize=10"

   # Sorted and filtered
   curl "http://localhost:5000/api/notes?tags=ai,learning&sortBy=created&sortOrder=desc"
   ```

5. **Submit PR**

---

## 🎯 Key Features to Implement

### **Full-Text Search:**
```csharp
notes.Where(n => 
    n.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
    n.Content.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
)
```

### **Tag Filtering:**
```csharp
notes.Where(n => 
    requestedTags.All(tag => n.Tags.Any(t => t.Name == tag))
)
```

### **Pagination:**
```csharp
notes
    .Skip((page - 1) * pageSize)
    .Take(pageSize)
```

### **Sorting:**
```csharp
sortBy switch {
    "created" => sortOrder == "desc" ? 
        notes.OrderByDescending(n => n.CreatedDate) :
        notes.OrderBy(n => n.CreatedDate),
    "title" => sortOrder == "desc" ?
        notes.OrderByDescending(n => n.Title) :
        notes.OrderBy(n => n.Title),
    _ => notes.OrderByDescending(n => n.CreatedDate)
}
```

---

## ✅ Success Criteria

### **Functionality (40%)**
- [ ] All CRUD endpoints working
- [ ] Search across title and content
- [ ] Tag filtering
- [ ] Pagination working correctly
- [ ] Sorting by multiple fields
- [ ] Proper HTTP status codes

### **Advanced Features (30%)**
- [ ] Multiple tag filtering (AND logic)
- [ ] Full-text search (case-insensitive)
- [ ] Efficient LINQ queries
- [ ] Complex filter combinations
- [ ] Tag management endpoints

### **Code Quality & Testing (30%)**
- [ ] Async/await throughout
- [ ] Unit tests (70%+ coverage)
- [ ] Integration tests for search/filter
- [ ] XML documentation complete
- [ ] SOLID principles followed
- [ ] Clean code architecture

---

## 📚 Advanced Features (If Time Permits)

- [ ] Add date range filtering
- [ ] Add note archiving (soft delete)
- [ ] Add note sharing/permissions
- [ ] Add note history/versioning
- [ ] Add rich text content support
- [ ] Add note export (PDF/Markdown)

---

## 🏆 Submission

1. Branch: `challenge/notes-api-{your-name}`
2. PR with Copilot-generated description
3. Complete checklist from README
4. All tests passing (70%+ coverage)

**Estimated Total Time: 50-60 minutes**

📝 Let's build something great! 📝

