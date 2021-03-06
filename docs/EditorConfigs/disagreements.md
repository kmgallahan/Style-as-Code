---
parent: EditorConfigs
title: Disagreements
nav_order: 3
search_exclude: true
---

Every developer likely has at least one coding style rule preference that will clash with any EditorConfig they adopt.

Some rules aren't particularly controversial (such as sorting namespaces), while others have definitive sides (such as use of `var`).

## Case Study: .NET Core Runtime vs. Roslyn Compiler

An interesting example of this can be observed by comparing the EditorConfig used by the [.NET Core Runtime](https://github.com/dotnet/runtime/blob/master/.editorconfig) with that of the [Roslyn Compiler](https://github.com/dotnet/roslyn/blob/master/.editorconfig).

To summarize, as of February 2020 between the files there are:

* 148 C# rules defined
* 58 are equal
* 25 are **not equal**
* 74 are defined in only one EditorConfig

The absence of a rule doesn't always indicate disagreement, as the default may be used by most contributors anyways. However, it does mean some contributors may see warnings and suggestions based on their own IDE settings.

Also, a rule being configured differently may mean both teams recommend the rule be followed, but one team marks it as `none` or `silent` and the other `suggestion`.

For those interested:

**Rules which are equal**
```
csharp_indent_block_contents
csharp_indent_braces
csharp_indent_case_contents
csharp_indent_case_contents_when_block
csharp_indent_switch_labels
csharp_new_line_before_catch
csharp_new_line_before_else
csharp_new_line_before_finally
csharp_new_line_before_members_in_anonymous_types
csharp_new_line_before_members_in_object_initializers
csharp_new_line_before_open_brace
csharp_new_line_between_query_expression_clauses
csharp_space_after_cast
csharp_space_after_colon_in_inheritance_clause
csharp_space_after_comma
csharp_space_after_dot
csharp_space_after_keywords_in_control_flow_statements
csharp_space_after_semicolon_in_for_statement
csharp_space_around_binary_operators
csharp_space_around_declaration_statements
csharp_space_before_colon_in_inheritance_clause
csharp_space_before_comma
csharp_space_before_dot
csharp_space_before_open_square_brackets
csharp_space_before_semicolon_in_for_statement
csharp_space_between_empty_square_brackets
csharp_space_between_method_call_empty_parameter_list_parentheses
csharp_space_between_method_call_name_and_opening_parenthesis
csharp_space_between_method_call_parameter_list_parentheses
csharp_space_between_method_declaration_empty_parameter_list_parentheses
csharp_space_between_method_declaration_name_and_open_parenthesis
csharp_space_between_method_declaration_parameter_list_parentheses
csharp_space_between_parentheses
csharp_space_between_square_brackets
csharp_style_conditional_delegate_call
csharp_style_inlined_variable_declaration
csharp_style_pattern_matching_over_as_with_null_check
csharp_style_pattern_matching_over_is_with_cast_check
csharp_style_throw_expression
dotnet_naming_style.pascal_case_style.capitalization
dotnet_naming_symbols.static_fields.required_modifiers
dotnet_sort_system_directives_first
dotnet_style_coalesce_expression
dotnet_style_collection_initializer
dotnet_style_explicit_tuple_names
dotnet_style_null_propagation
dotnet_style_object_initializer
dotnet_style_predefined_type_for_locals_parameters_members
dotnet_style_predefined_type_for_member_access
indent_size
indent_style
insert_final_newline
```

**Rules which are not equal**
```
csharp_indent_labels
csharp_prefer_braces
csharp_preserve_single_line_blocks
csharp_preserve_single_line_statements
csharp_style_expression_bodied_accessors
csharp_style_expression_bodied_constructors
csharp_style_expression_bodied_indexers
csharp_style_expression_bodied_methods
csharp_style_expression_bodied_operators
csharp_style_expression_bodied_properties
csharp_style_var_elsewhere
csharp_style_var_for_built_in_types
csharp_style_var_when_type_is_apparent
dotnet_naming_rule.constant_fields_should_be_pascal_case.severity
dotnet_naming_rule.constant_fields_should_be_pascal_case.style
dotnet_naming_rule.constant_fields_should_be_pascal_case.symbols
dotnet_naming_style.static_prefix_style.capitalization
dotnet_naming_style.static_prefix_style.required_prefix
dotnet_naming_symbols.constant_fields.applicable_kinds
dotnet_naming_symbols.constant_fields.required_modifiers
dotnet_naming_symbols.static_fields.applicable_kinds
dotnet_style_qualification_for_event
dotnet_style_qualification_for_field
dotnet_style_qualification_for_method
dotnet_style_qualification_for_property
```

**Rules only defined in only one EditorConfig**
```
csharp_prefer_simple_default_expression
csharp_prefer_simple_using_statement
csharp_prefer_static_local_function
csharp_preferred_modifier_order
csharp_style_expression_bodied_lambdas
csharp_style_expression_bodied_local_functions
csharp_style_pattern_local_over_anonymous_function
csharp_style_prefer_index_operator
csharp_style_prefer_range_operator
csharp_style_prefer_switch_expression
csharp_using_directive_placement
dotnet_code_quality.ca1802.api_surface
dotnet_code_quality_unused_parameters
dotnet_diagnostic.RS0037.severity
dotnet_naming_rule.camel_case_for_private_internal_fields.severity
dotnet_naming_rule.camel_case_for_private_internal_fields.style
dotnet_naming_rule.camel_case_for_private_internal_fields.symbols
dotnet_naming_rule.instance_fields_should_be_camel_case.severity
dotnet_naming_rule.instance_fields_should_be_camel_case.style
dotnet_naming_rule.instance_fields_should_be_camel_case.symbols
dotnet_naming_rule.local_functions_should_be_pascal_case.severity
dotnet_naming_rule.local_functions_should_be_pascal_case.style
dotnet_naming_rule.local_functions_should_be_pascal_case.symbols
dotnet_naming_rule.locals_should_be_camel_case.severity
dotnet_naming_rule.locals_should_be_camel_case.style
dotnet_naming_rule.locals_should_be_camel_case.symbols
dotnet_naming_rule.members_should_be_pascal_case.severity
dotnet_naming_rule.members_should_be_pascal_case.style
dotnet_naming_rule.members_should_be_pascal_case.symbols
dotnet_naming_rule.non_private_readonly_fields_should_be_pascal_case.severity
dotnet_naming_rule.non_private_readonly_fields_should_be_pascal_case.style
dotnet_naming_rule.non_private_readonly_fields_should_be_pascal_case.symbols
dotnet_naming_rule.non_private_static_fields_should_be_pascal_case.severity
dotnet_naming_rule.non_private_static_fields_should_be_pascal_case.style
dotnet_naming_rule.non_private_static_fields_should_be_pascal_case.symbols
dotnet_naming_rule.static_fields_should_be_camel_case.severity
dotnet_naming_rule.static_fields_should_be_camel_case.style
dotnet_naming_rule.static_fields_should_be_camel_case.symbols
dotnet_naming_rule.static_fields_should_have_prefix.severity
dotnet_naming_rule.static_fields_should_have_prefix.style
dotnet_naming_rule.static_fields_should_have_prefix.symbols
dotnet_naming_style.camel_case_style.capitalization
dotnet_naming_style.camel_case_underscore_style.capitalization
dotnet_naming_style.camel_case_underscore_style.required_prefix
dotnet_naming_style.constant_style.capitalization
dotnet_naming_style.instance_field_style.capitalization
dotnet_naming_style.instance_field_style.required_prefix
dotnet_naming_style.local_function_style.capitalization
dotnet_naming_style.non_private_readonly_field_style.capitalization
dotnet_naming_style.non_private_static_field_style.capitalization
dotnet_naming_symbols.all_members.applicable_kinds
dotnet_naming_symbols.instance_fields.applicable_kinds
dotnet_naming_symbols.local_functions.applicable_kinds
dotnet_naming_symbols.locals_and_parameters.applicable_kinds
dotnet_naming_symbols.non_private_readonly_fields.applicable_accessibilities
dotnet_naming_symbols.non_private_readonly_fields.applicable_kinds
dotnet_naming_symbols.non_private_readonly_fields.required_modifiers
dotnet_naming_symbols.non_private_static_fields.applicable_accessibilities
dotnet_naming_symbols.non_private_static_fields.applicable_kinds
dotnet_naming_symbols.non_private_static_fields.required_modifiers
dotnet_naming_symbols.private_internal_fields.applicable_accessibilities
dotnet_naming_symbols.private_internal_fields.applicable_kinds
dotnet_naming_symbols.static_fields.applicable_accessibilities
dotnet_style_prefer_auto_properties
dotnet_style_prefer_conditional_expression_over_assignment
dotnet_style_prefer_conditional_expression_over_return
dotnet_style_prefer_inferred_anonymous_type_member_names
dotnet_style_prefer_inferred_tuple_names
dotnet_style_prefer_is_null_check_over_reference_equality_method
dotnet_style_readonly_field
trim_trailing_whitespace
```