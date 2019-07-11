# Firebase.Cloud.Sample
Simple sample for firebase ios/android. Contains auth and work with cloud firestore.

Sample related on https://github.com/f-miyu/Plugin.FirebaseAuth and https://github.com/f-miyu/Plugin.CloudFirestore

Rules used

```
rules_version = '2';
service cloud.firestore {
  match /databases/{database}/documents {
    // A read rule can be divided into get and list rules
    match /places/{id} {
    	// Applies to single document read requests
      allow get: if request.auth.uid != null;

      // Applies to queries and collection read requests
      allow list: if request.auth.uid != null;
    }

    // A write rule can be divided into create, update, and delete rules
    function isPostOwner() {
       return resource.data.OwnerId == request.auth.uid;
    }

    // A write rule can be divided into create, update, and delete rules
    match /places/{id} {
      // Applies to writes to nonexistent documents
      allow create: if request.auth.uid != null;

      // Applies to writes to existing documents
      allow update: if isPostOwner();

      // Applies to delete operations
      allow delete: if isPostOwner();
  	}
  }
}
```
