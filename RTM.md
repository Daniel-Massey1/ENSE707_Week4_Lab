 | Requirement ID | Requirement Summary | Acceptance Criteria | Test Case | Status |
| :--- | :--- | :--- | :--- | :--- |
| **REQ-LIB-01** | Reserve only available book | AC-01 | `ReserveBook_AvailableBookAndValidMember_ReturnsSuccess`<br>`ReserveBook_AvailableBook_MarksBookAsReserved` | Passed |
| **REQ-LIB-02** | Reject empty member ID | AC-02 | `Member_EmptyMemberId_ThrowsException` | Passed |
| **REQ-LIB-03** | Reject already reserved book | AC-03 | `ReserveBook_AlreadyReservedBook_ReturnsFailure` | Passed |
| **REQ-LIB-04** | Return clear success or failure message | AC-04 | `ReserveBook_NullBook_ReturnsClearFailureMessage`<br>`ReserveBook_NullMember_ReturnsClearFailureMessage` | Passed |
| **REQ-LIB-05** | Limit member to one active reservation | AC-05 | `ReserveBook_MemberHasExistingReservation_ReturnsFailure` | Planned |

Traceability helps the team check whether each requirement has test evidence. It also
supports change management because if a requirement changes, the related test cases can
be identified, reviewed, and updated.